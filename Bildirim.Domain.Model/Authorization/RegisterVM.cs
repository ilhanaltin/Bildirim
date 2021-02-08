
namespace Bildirim.Domain.Model.Authorization
{
    public class RegisterVM : BaseVM
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
