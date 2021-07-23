using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{

    public class Array123
    {
        /// <summary>
        /// Given an int array, return true it contains the sequence 1,2,3; else false
        /// </summary>
        /// <param name="nums">An int array</param>
        /// <returns>a boolean</returns>
        public bool Has123(int[] nums)
        {
            for(int i = 0; i<=nums.Length-2; i++)
            {
                if (nums[i] == 1)
                {
                    if((i+1 >= nums.Length) || (i+2 >= nums.Length))
                    {
                        return false;
                    }
                    else if (nums[i + 1] == 2)
                    {
                        if (nums[i + 2] == 3)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
