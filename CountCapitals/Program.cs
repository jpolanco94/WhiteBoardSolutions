using System;

namespace CountCapitals
{
    class Program
    {
        //Given a string, return an int of how many capitals are in that string
        public static int CountCapitals(string sentence)
        {
            int count = 0;

            foreach (char letter in sentence)
            {
                if (char.IsUpper(letter))
                {
                    count++;
                }
            }
            return count;
        }

