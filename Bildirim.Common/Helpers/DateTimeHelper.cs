using System;
using System.Collections.Generic;
using System.Text;

namespace Bildirim.Common.Helpers
{
    public class DateTimeHelper
    {
        public static DateTime ToLocalTime(DateTime utcDate)
        {
            var localTimeZoneId = "Turkey Standard Time";
            var localTimeZone = TimeZoneInfo.FindSystemTimeZoneById(localTimeZoneId);
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(utcDate, localTimeZone);
            return localTime;
        }
    }
}
