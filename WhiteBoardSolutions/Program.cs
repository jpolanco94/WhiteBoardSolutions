using System;

namespace WhiteBoardSolutions
{
    class Program
    {
        //Asked to create a method that given a month and day, returns a julian date.
        //Expanded to take into account leap years.
        public static int GetJulianDate(int mon, int day, int year)
        {
            int julianDay = day;
            if (year % 4 != 0)
            {
                int[] month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                for (int i = 0; i < mon; i++)
                {
                    julianDay += month[i];
                }
            }
            if (year % 4 == 0)
            {
                int[] month = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                for (int i = 0; i < mon; i++)
                {
                    julianDay += month[i];
                }
            }
            return julianDay;
        }
        static void Main(string[] args) { }
    }
}
