using System;
using System.Collections.Generic;
using System.Text;

namespace Bildirim.Common.Types
{
    public class ContactRequest
    {
        public long? UserId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Message { get; set; }
    }
}
