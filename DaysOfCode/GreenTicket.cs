using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    public class GreenTicket
    {
        /// <summary>
        /// Compare three lotto numbers, returning 10 if two match
        /// and 20 if all three match, else zero.
        /// </summary>
        /// <param name="a">first lotto number</param>
        /// <param name="b">second lotto number</param>
        /// <param name="c">third lotto number</param>
        /// <returns>value of the ticket</returns>
        public int TicketValue(int a, int b, int c)
        {
            if ((a == b) && (b==c))
            {
                return 20;
            }
            else if((a==b) || (b==c) || (a == c))
            {
                return 10;
            }

            return 0;
        }
    }
}
