using System;
using System.Collections.Generic;

namespace AverageLengthOfString
{
    class Program
    {
        public static double AverageLength(List<string> words)
        {
            int sum = 0;
            foreach (string x in words)
            {
                sum += x.Length;
            }
            return sum / words.Count;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
}
