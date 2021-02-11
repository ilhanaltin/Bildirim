using Bildirim.Common.Types;
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

        public static StartEndDateVM GetStartEndDateFromString(string dateString)
        {
            var result = new StartEndDateVM();

            int countOfMonths = 0;

            foreach (var m in Constants.monthNames)
            {
                if (dateString.ToLower().Contains(m))
                    countOfMonths++;
            }

            if(countOfMonths == 1)
            {
                //Sample: 5-25 Şubat 2021

                var dateParts = dateString.Split(" ");

                var days = dateParts[0].Split("-");

                int year = Convert.ToInt32(dateParts[2]);
                int month = Convert.ToInt32(Array.IndexOf(Constants.monthNames, dateParts[1].ToLower()) + 1);
                int dayStart = Convert.ToInt32(days[0]);
                int dayEnd = Convert.ToInt32(days[1]);

                result.StartDate = new DateTime(year, month, dayStart, 0, 0, 0);
                result.EndDate = new DateTime(year, month, dayEnd, 23, 59, 59);
            }
            else
            {
                //Sample: 16 Ocak-15 Şubat 2021

                var dateParts = dateString.Split(" ");
                var firstMonthAndSecondDay = dateParts[1].Split("-");

                int year = Convert.ToInt32(dateParts[2]);
                int firstMonth = Convert.ToInt32(Array.IndexOf(Constants.monthNames, firstMonthAndSecondDay[0].ToLower() + 1));
                int secondMonth = Convert.ToInt32(Array.IndexOf(Constants.monthNames, dateParts[2].ToLower()) + 1);
                int dayStart = Convert.ToInt32(dateParts[0]);
                int dayEnd = Convert.ToInt32(firstMonthAndSecondDay[1]);

                result.StartDate = new DateTime(year, firstMonth, dayStart, 0, 0, 0);
                result.EndDate = new DateTime(year, secondMonth, dayEnd, 23, 59, 59);
            }


            return result;
        }
    }
}