using System;
using System.Collections.Generic;
using System.Text;

namespace Bildirim.Domain.Model.ReqRes
{
    public class ChangePasswordPostRequest
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class ChangePasswordByRecoverPostRequest
    {
        public string Token { get; set; }
        public string NewPassword { get; set; }
    }

    public class PasswordRecoverPostRequest
    {
        public string Email { get; set; }
    }

    public class ChangePasswordResponseDetails
    {

    }
}
