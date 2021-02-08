using System;
using System.Collections.Generic;
using System.Text;

namespace Bildirim.Common
{
    public class ApplicationConfig
    {
        public string JWTSecretKey { get; set; }

        public TimeSpan TokenLifetime { get; set; }
    }
}
