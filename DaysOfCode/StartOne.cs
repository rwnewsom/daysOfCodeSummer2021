using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    public class StartOne
    {
        /// <summary>
        /// Takes Takes two arrays, returns how many arrays have 1 as their first element.
        /// </summary>
        /// <param name="a">The first integer array</param>
        /// <param name="b">The second integer array</param>
        /// <returns></returns>
        public int StartOneCount(int[] a, int[] b)
        {
            int count = 0;

            if (a[0] == 1)
            {
                count++;
            }
            if (b[0] == 1)
            {
                count++;
            }

            return count;
        }
    }
}
