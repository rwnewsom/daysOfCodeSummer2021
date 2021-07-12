using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    public class HasTwelve
    {
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
