﻿
namespace Bildirim.Domain.Model.Notify
{
    public class NotificationVM : BaseVM
    {
        public string Name { get; set; }

        public long NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; }

        public long NotificationStatusTypeId { get; set; }
        public string NotificationStatusTypeAdi { get; set; }

        public int ReadCount { get; set; }

        public long CountryId { get; set; }
        public string CountryAdi { get; set; }

        public long? CityId { get; set; }
        public string CityAdi { get; set; }

        public long? CountyId { get; set; }
        public string CountyAdi { get; set; }

        public string Message { get; set; }
    }
}
