using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_10
{
    public static class DateExtensions
    {
        public static DateTime NextDate(int year, int month, int day)
        {
            Validate(year, month, day);

            int NumberOfDaysInMonth = NumberOfDaysForGivenYearAndMonth(year, month);
            
            if (day < NumberOfDaysInMonth)
            {
                day++;
            }
            else
            {
                day = 1;
                if (month < 12)
                {
                    month++;
                }
                else
                {
                    month = 1;
                    year++;
                }
            }

            return new DateTime(year, month, day);
        } 

        private static int NumberOfDaysForGivenYearAndMonth(int year, int month)
        {
            int d = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;

                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    {
                        d = 29;
                    }
                    else
                    {
                        d = 28;
                    }
                    break;
            }

            return d;
        }


        private static void Validate(int y, int m, int d)
        {
            if (d < 1 && d > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(d));
            }

            if (m < 1 && m > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(m));
            }

            if (y < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(y));
            }
        }
    }
}
