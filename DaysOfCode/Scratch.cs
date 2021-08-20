using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCode
{
    /// <summary>
    /// For testing code blocks and brainstorming
    /// </summary>
    public class Scratch
    {
        public void ScratchPad()
        {
            Fibonacci fibonacci = new Fibonacci();

            List<int> fibSequence = fibonacci.FibSequence(300);

            foreach (int i in fibSequence)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
