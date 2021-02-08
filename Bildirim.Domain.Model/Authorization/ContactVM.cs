
namespace Bildirim.Domain.Model.Authorization
{
    public class ContactVM : BaseVM
    {
        public long? UserId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Message { get; set; }
    }
}