
namespace Bildirim.Domain.Model.Shared
{
    public class PagingVM
    {
        public int TotalCount { get; set; }
        public decimal TotalPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageItemCount { get; set; }
    }
}
