using System;

namespace SwapIntegers
{
    class Program
    {
        //Given two integers, swap their values without using a new variable
        public static string Swap(int A, int B)
        {
            B = A + B;
            A = B - A;
            B = B - A;

            return $"{A},{B}";
        }
    }
}
