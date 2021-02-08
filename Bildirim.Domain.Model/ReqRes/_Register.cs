
using Bildirim.Common;

namespace Bildirim.Domain.Model.ReqRes
{
    public class RegisterRequest
    {
        public RegisterRequest()
        {
            this.UserLoginTypeId = Constants.USER_LOGIN_NORMAL;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public long RoleId { get; set; }
        public string Password { get; set; }
        public long UserLoginTypeId { get; set; }
    }

    public class RegisterResponseDetails
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public long RoleId { get; set; }
    }
}
