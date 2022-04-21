using System;

namespace MyNamespace
{
    public class DateService
    {
        public static int AllDayNumber (int day, int month, int year)
        {
            int sumofdays = year * 365 + (year - 1) / 4 + day;
            if (month > 1)
            {
                sumofdays += 31;
                if (month > 2)
                {
                    if (year % 4 == 0)
                        sumofdays++;
                    sumofdays += 28;
                    if (month > 3)
                    {
                        sumofdays += 31;
                        if (month > 4)
                        {
                            sumofdays += 30;
                            if (month > 5)
                            {
                                sumofdays += 31;
                                if (month > 6)
                                {
                                    sumofdays += 30;
                                    if (month > 7)
                                    {
                                        sumofdays += 31;
                                        if (month > 8)
                                        {
                                            sumofdays += 31;
                                            if (month > 9)
                                            {
                                                sumofdays += 30;
                                                if (month > 10)
                                                {
                                                    sumofdays += 31;
                                                    if (month > 11)
                                                    {
                                                        sumofdays += 30;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return sumofdays;
        }
        public static bool CheckDate(int day, int month, int year)
        {
            if (month > 12 || month < 1 || day < 1)
                return false;
            if (month == 1 && day > 31)
                return false;
            else if (month == 2 && day > 28)
                if (day > 29 || (year%4!=0 && day>28))
                    return false;
            else if (month == 3 && day > 31)
                return false;
            else if (month == 4 && day > 30)
                return false;
            else if (month == 5 && day > 31)
                return false;
            else if (month == 6 && day > 30)
                return false;
            else if (month == 7 && day > 31)
                return false;
            else if (month == 8 && day > 31)
                return false;
            else if (month == 9 && day > 30)
                return false;
            else if (month == 10 && day > 31)
                return false;
            else if (month == 11 && day > 30)
                return false;
            else if (month == 12 && day > 31)
                return false;
            return true;
        }
        public static int GetDay(string date) 
        {
            int day, year, month;
            if (date.Length != 10)
                return -1;
            if (!int.TryParse(date.Substring(0, 2), out day))
                return -1;
            if (!int.TryParse(date.Substring(3, 2), out month))
                return -1;
            if (!int.TryParse(date.Substring(6, 4), out year))
                return -1;
            if (!CheckDate(day, month, year))
                return -1;
            return (4+AllDayNumber(day, month, year)) % 7 + 1;
        }
        public static int GetSpan(string date)
        {
            int day, year, month;
            if (date.Length != 10)
                return -1;
            if (!int.TryParse(date.Substring(0, 2), out day))
                return -1;
            if (!int.TryParse(date.Substring(3, 2), out month))
                return -1;
            if (!int.TryParse(date.Substring(6, 4), out year))
                return -1;
            if (!CheckDate(day, month, year))
                return -1;
            return GetDaysSpan(day, month, year);
        }
        public static int GetDaysSpan(int day, int month, int year)
        {
            DateTime currentdate = DateTime.Now;
            return Math.Abs(AllDayNumber(currentdate.Day, currentdate.Month, currentdate.Year)-AllDayNumber(day, month, year));
        }
    }
}