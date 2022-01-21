using System;

namespace Onliner.Utils
{
    public static class DateHelper
    {
        // <FIX> Day. Not Date
        public static int GetTodaysDate()
        {
            int currentDate = DateTime.Today.Day;

            return currentDate;
        }

        public static string GetCurrentMonth()
        {
            int currentMonth = DateTime.Today.Month;

            return Month.Months[currentMonth];
        }
    }
}
