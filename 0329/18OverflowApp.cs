using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class OverflowApp
    {
        static void Main(string[] args)
        {
            int i, max = int.MaxValue;

            try
            {
                Console.WriteLine("Start of try satement");
                i = max + 1;

                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + 1; // don't check Overflow
                }
                Console.WriteLine("After unchecked statement");

                checked
                {
                    i = max + 1; // check Overflow
                }
                Console.WriteLine("After checked statement");
            }

            catch (OverflowException e)
            {
                Console.WriteLine("caught an OverflowException");
            }
        }
    }
}
