using Bildirim.Domain.Model.Authorization;
using Bildirim.Domain.Model.Shared;
using System.Collections.Generic;

namespace Bildirim.Domain.Model.ReqRes
{
    public class ContactListRequest
    {
        public int ItemCount { get; set; }
        public int PageId { get; set; }
    }

    public class ContactListResponseDetails
    {
        public List<ContactVM> ContactList { get; set; }

        public PagingVM PagingVM { get; set; }
    }
}
