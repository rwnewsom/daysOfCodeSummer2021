using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    public class HasTwelve
    {
        /// <summary>
        /// Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in the array.
        /// </summary>
        /// <param name="nums">An integer array</param>
        /// <returns>a boolean</returns>
        public bool hasOneThenTwo(int[] nums)
        {
            bool foundOne = false;
            foreach (int num in nums)
            {
                if (num == 1)
                {
                    foundOne = true;
                }

                if (num == 2)
                {
                    if (foundOne)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
