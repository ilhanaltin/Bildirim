using System;

namespace Bildirim.Common.Auth
{
    public class JwtPayLoad
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }

        // It was added 2 minutes only for demo, do not do it in production.
        public DateTime Exp { get; set; }

        public JwtPayLoad()
        {
            Exp = DateTime.UtcNow.AddYears(1);
        }

        public JwtPayLoad(long id, string name, string lastName, string email, int roleId, string role, DateTime tokenExp)
        {
            UserId = id;
            Name = name;
            LastName = lastName;
            Email = email;
            RoleId = roleId;
            Role = role;
            Exp = tokenExp;
        }
    }
}
