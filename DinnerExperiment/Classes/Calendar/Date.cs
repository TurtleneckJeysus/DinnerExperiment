//Date.cs***************************************************
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerExperiment.Classes.Calendar
{
    internal static class Date
    {
        public static DateTime WeekOfMonday(this DateTime dt)
        {

            var today = DateTime.Today;


            return new GregorianCalendar().AddDays(today, -(int)today.DayOfWeek + 1);
        }
        public static void NextMonday()
        {
            var monday = DateTime.Now.WeekOfMonday();
            Console.WriteLine($"The Meal Plan For The Week Of {monday:d} \n");
        }
    }
}
