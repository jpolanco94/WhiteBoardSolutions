using System;

namespace CentimetersToFeetAndInches
{
    class Program
    {
        public static void ToFeetAndInches(double centimeters)
        {
            double inches = centimeters / 2.54;
            double remainderInches = inches % 12;
            double feet = (inches - remainderInches) / 4;
            Console.WriteLine($"{feet} feet and {remainderInches} inches.");
        }
        static void Main(string[] args)
        {
            ToFeetAndInches(400);
        }
    }
}
