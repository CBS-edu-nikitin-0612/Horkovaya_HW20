using System;
namespace Task5
{
    static class DateCounter
    {
        public static int DaysToBirthday(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int day = birthday.Day;
            int month = birthday.Month;
            int year = DateTime.Today.Year;
            if (today.Month > month)
            {
                year += 1;
            }
            DateTime nextBithday = new DateTime(year, month, day);
            TimeSpan time = nextBithday - today;
            return time.Days;
        }
    }
}