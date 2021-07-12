using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    public class Only14
    {
        /// <summary>
        /// Given an array of ints, return true if the only numbers are 
        /// either '1' or '4'; else return false
        /// </summary>
        /// <param name="nums">an integer array</param>
        /// <returns>boolean</returns>
        public bool isOnlyOneFour(int[] nums)
        {
            foreach (int num in nums)
            {
                if(num!=1)
                {
                    if (num != 4)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
