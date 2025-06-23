using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_day__at_night
{
    internal class Birthday
    {
        int day;
        int month;
        int year;
        public Birthday(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void ShowBirthday() {Console.WriteLine($"Birthday: {day}.{month}.{year}");}

        public void DayInWeekOfBirthday() { DateTime birthday = new DateTime(year, month, day); Console.WriteLine($"Day of the week on birthday: {birthday.DayOfWeek}");}

        public void WhatDayOnNumber(int day, int month, int year) { Birthday birthday = new Birthday(day, month, year); DateTime date = new DateTime(year, month, day); Console.WriteLine($"What day on {day}.{month}.{year} Выходииит: {date.DayOfWeek}"); }

        public void HowManyDaysToBirthday()
        {

        }
    }
    

}
