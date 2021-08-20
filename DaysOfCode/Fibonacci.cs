using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    public class Fibonacci
    {
        public List<int> FibSequence(int target)
        {
            List<int> sequence = new List<int>();
            sequence.Add(0);
            if (target == 0)
            {
                return sequence;
            }
            sequence.Add(1);
            if (target == 1)
            {
                return sequence;
            }
            int firstNum = 0;
            int secondNum = 1;

            while ((secondNum+firstNum)<= target)
            {
                int next = secondNum + firstNum;
                sequence.Add(next);
                firstNum = secondNum;
                secondNum = next;
            }
            return sequence;
        }
    }
}
