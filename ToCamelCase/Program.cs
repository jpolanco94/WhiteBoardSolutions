using System;

namespace ToCamelCase
{
    class Program
    {
        //Give a string of any length, return a string in camel case.
        public static string toCamelCase(string inputString)
        {
            bool isNewWord = false;
            string camelCaseString = "";

            if (inputString.Length < 1 || char.IsDigit(inputString[0]))
            {
                return "";
            }

            inputString = inputString.ToLower();

            for (int i = 0; i < inputString.Length; i++)
            {
                char nextChar = inputString[i];

                if (char.IsWhiteSpace(nextChar))
                {
                    if (camelCaseString.Length > 1) isNewWord = true;
                    continue;
                }
                else if (char.IsPunctuation(nextChar))
                {
                    continue;
                }

                camelCaseString += isNewWord ? char.ToUpper(nextChar) : nextChar;
                isNewWord = false;
            }
            return camelCaseString;
        }

    }
}

