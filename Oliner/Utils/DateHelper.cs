﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onliner.Utils
{
    public static class DateHelper
    {
        public static string GetTodaysDateAndMonth()
        {
            string currentDate = DateTime.Now.Date.ToLongDateString();
            string dateAndMounth = currentDate.Remove(9);

            return dateAndMounth;
        }
    }
}
