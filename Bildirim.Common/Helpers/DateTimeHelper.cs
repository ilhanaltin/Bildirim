using Bildirim.Common.Types;
using System;
using System.Linq;

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
            dateString = dateString.Trim();

            var result = new StartEndDateVM();

            int countOfMonths = 0;

            foreach (var m in Constants.monthNames)
            {
                countOfMonths += dateString.Split(" ").Count(t => t.ToLower().Trim().Contains(m));
            }

            try
            {                
                if (countOfMonths == 1)
                {
                    //Sample: 5-25 Şubat 2021
                    var dates = dateString.Split("-");

                    if (dates.Length == 1)
                        dates = dateString.Split("–");

                    // 31 Aralık 2021
                    if (dates.Length == 1)
                    {
                        dates = dateString.Split(" ");

                        result.StartDate = DateTime.Today;
                        result.EndDate = new DateTime(Convert.ToInt32(dates[2]), Convert.ToInt32(Array.IndexOf(Constants.monthNames, dates[1].ToLower()) + 1), Convert.ToInt32(dates[0]), 0, 0, 0);
                    }
                    else
                    {
                        int dayStart = Convert.ToInt32(dates[0]);

                        var dateValuesEnd = dates[1].Trim().Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

                        int dayEnd = Convert.ToInt32(dateValuesEnd[0]);
                        int secondMonth = Convert.ToInt32(Array.IndexOf(Constants.monthNames, dateValuesEnd[1].ToLower()) + 1);
                        int year = Convert.ToInt32(dateValuesEnd[2]);

                        result.StartDate = new DateTime(year, secondMonth, dayStart, 0, 0, 0);
                        result.EndDate = new DateTime(year, secondMonth, dayEnd, 23, 59, 59);
                    }
                }
                else
                {
                    //Sample: 16 Ocak-15 Şubat 2021
                    var dates = dateString.Split("-");

                    if (dates.Length == 1)
                        dates = dateString.Split("–");

                    if (dates.Length == 1)
                        dates = dateString.Split("/");

                    string[] dateValuesStart = new string[2];
                    string[] dateValuesEnd = new string[2];

                    if (dateString.Contains("."))
                    {
                        dateValuesStart = dates[0].Trim().Split(".").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                        dateValuesEnd = dates[1].Trim().Split(".").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    }
                    else
                    {
                        dateValuesStart = dates[0].Trim().Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                        dateValuesEnd = dates[1].Trim().Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    }

                    int dayStart = Convert.ToInt32(dateValuesStart[0]);

                    int firstMonth = 0;
                    if (!int.TryParse(dateValuesStart[1], out firstMonth))
                    {
                        firstMonth = Convert.ToInt32(Array.IndexOf(Constants.monthNames, dateValuesStart[1].ToLower()) + 1);
                    }

                    var yearStart = dateValuesStart.Length == 3 ? Convert.ToInt32(dateValuesStart[2]) : Convert.ToInt32(dateValuesEnd[2]);

                    int dayEnd = Convert.ToInt32(dateValuesEnd[0]);

                    int secondMonth = 0;
                    if (!int.TryParse(dateValuesEnd[1], out secondMonth))
                    {
                        secondMonth = Convert.ToInt32(Array.IndexOf(Constants.monthNames, dateValuesEnd[1].ToLower()) + 1);
                    }

                    int yearEnd = Convert.ToInt32(dateValuesEnd[2]);

                    result.StartDate = new DateTime(yearStart, firstMonth, dayStart, 0, 0, 0);
                    result.EndDate = new DateTime(yearEnd, secondMonth, dayEnd, 23, 59, 59);
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return result;
        }
    }
}