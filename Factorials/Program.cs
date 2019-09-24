using System;

namespace Factorials
{
    class Program
    {
        public static int CalculateFactorial(int input)
        {
            int factorial = 1;
            if (input == 0 || input == 1) return 1;
            for (int i = 1; i <= input; i++)
            {
                if (factorial >= int.MaxValue / input)
                {
                    throw new StackOverflowException("The factorial became too large!");
                    
                }
                factorial = factorial * i;
            }
            return factorial;
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(CalculateFactorial(13));
        }
    }
}
