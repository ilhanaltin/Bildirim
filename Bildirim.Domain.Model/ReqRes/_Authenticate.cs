using Bildirim.Domain.Model.Authorization;

namespace Bildirim.Domain.Model.ReqRes
{
    public class AuthenticateRequest
    {
        public AuthenticateRequest()
        {
            FromAdmin = false;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public bool FromAdmin { get; set; }
    }

    public class SocialAuthenticateRequest
    {
        public string Provider { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class LoginResponseDetails
    {
        public LoginResponseDetails()
        {
            User = new UserVM();
        }

        public UserVM User { get; set; }
        public string Token { get; set; }
    }
}
