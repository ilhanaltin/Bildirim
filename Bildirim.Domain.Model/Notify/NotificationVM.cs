using System;
using System.Collections.Generic;

namespace Bildirim.Domain.Model.Notify
{
    public class NotificationVM : BaseVM
    {
        public string DetailLink { get; set; }

        public string MainImageLink { get; set; }

        public string LogoLink { get; set; }

        public string IconLink { get; set; }

        public long NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DetailText { get; set; }

        public int ReadCount { get; set; }

        public long LikeCount { get; set; }
    }
}
