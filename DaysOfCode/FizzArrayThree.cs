using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{ //TODO: TEST THIS!
    public class FizzArrayThree
    {
        /// <summary>
        /// Return a new array from first int counting up to, but not
        /// including, last int
        /// </summary>
        /// <param name="a">starting integer</param>
        /// <param name="b">ending integer - not included in new array</param>
        /// <returns>an array of integers length b-a</returns>
        public int[] MakeFizzArray(int a, int b)
        {
            int[] fizzed = new int[b - a];

            //for (int i = 0, j = a; i < fizzed.Length-1; i++, j++)
            for (int i = 0, j = a; j < b; i++, j++)
            {
                fizzed[i] = j;
            }

            return fizzed;

        }
    }
}
