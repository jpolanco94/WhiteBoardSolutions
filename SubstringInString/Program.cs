using System;

namespace SubstringInString
{
    public class Program
    {
        public static int FindIndexOfSubstring(string str, string substr)
        {
            for(int i = 0; i<str.Length; i++)
            {
                if(str[i] == substr[0])
                {
                    for(int j = 0; j < substr.Length; j++)
                    {
                        if(str[i + j] != substr[j])
                        {
                            break;
                        }
                    }
                }
            }
            return -1;
        }
        static void Main (string[] args)
        { }
    }
}
