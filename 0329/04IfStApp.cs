using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class IfStApp
    {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number = ");
            n = Console.Read() - '0';

            if (n%2 == 0)
                Console.WriteLine(n + " is an even number.");

            if (n%2 != 0)
                Console.WriteLine(n + " is an odd number.");
        }
    }
}
