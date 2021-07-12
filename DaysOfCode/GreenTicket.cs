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
        public int ticketValue(int a, int b, int c)
        {
            int winnings = 0;
            if (a == b)
            {
                if (a == c)
                {
                    winnings = 20;
                    return winnings;
                }
                winnings = 10;
                return winnings;
            }

            return winnings;
        }
    }
}
