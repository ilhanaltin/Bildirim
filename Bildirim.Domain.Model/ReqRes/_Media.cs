using Bildirim.Domain.Model.Shared;
using System.Collections.Generic;

namespace Bildirim.Domain.Model.ReqRes
{
    public class MediaRequest
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string FileName { get; set; }
        public string File { get; set; }
    }

    public class MediaListRequest
    {
        public int ItemCount { get; set; }
        public int PageId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }

    public class MediaListResponseDetails
    {
        public List<MediaVM> MediaList { get; set; }
        public PagingVM PagingVM { get; set; }
    }
}
