using Bildirim.Domain.Model.Authorization;
using Bildirim.Domain.Model.Shared;
using System.Collections.Generic;

namespace Bildirim.Domain.Model.ReqRes
{
    public class UserRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public long RoleId { get; set; }
        public long StatusId { get; set; }
    }

    public class ChangeEmailRequest
    {
        public long UserId { get; set; }
        public string Email { get; set; }
    }

    public class VerifyUserRequest
    {
        public string Token { get; set; }
    }

    public class UserResponseDetails
    {
        public UserVM UserVM { get; set; }
    }

    public class UserListRequest
    {
        public UserListRequest()
        {
            this.RoleId = -1;
        }

        public int RoleId { get; set; }
        public int ItemCount { get; set; }
        public int PageId { get; set; }
    }

    public class UserListResponseDetails
    {
        public List<UserVM> UserList { get; set; }

        public PagingVM PagingVM { get; set; }
    }
}
