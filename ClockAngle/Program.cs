using System;

namespace ClockAngle
{
    class Program
    {
        //Given an Hour and Minute, calculate the angle between the two hands of the clock
        public static double AngleDiff(int Hour, int Minute)
        {
            double minuteAngle = (double)Minute / 60.0 * 360.0;
            double hourAngle = (double)Hour / 12 * 360.0;

            double diff = Math.Abs(minuteAngle - hourAngle);
            if (diff > 180) return 360 - diff;
            return diff;
        }
        static void Main(string[] args)
        { }
    }
}
