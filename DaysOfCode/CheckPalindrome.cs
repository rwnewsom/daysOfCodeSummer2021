using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    public class CheckPalindrome //TODO: make input lower case
    {
        /// <summary>
        /// determines if a given string is a palindrome e.g. 'radar', 'rotor'
        /// </summary>
        /// <param name="inputString">String to be evaluated</param>
        /// <returns>a boolean</returns>
        public bool IsPalindrome(string inputString)
        {
            int min = 0;
            int max = inputString.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char first = inputString[min];
                char last = inputString[max];
                if (first != last)
                {
                    return false;
                }
                min++;
                max--;
            }

        }

        public bool RecursivePalindromeChecker(string inputString)
        {
            if (inputString.Length <= 1)
            {
                return true;
            }
            else if (inputString[0] != inputString[inputString.Length - 1])
            {
                return false;
            }
            else
            {
                return RecursivePalindromeChecker(inputString[1..^1]);
            }

        }
    }
}
