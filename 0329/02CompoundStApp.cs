using System;

namespace _0329
{
    class CompoundStApp
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter ont digit = ");
            n = Console.Read();
            Console.WriteLine(n);

            if (n < 0)
            {
                Console.WriteLine("Negative number!");
            }

            else
            {
                Console.WriteLine(n + "squared is " + (n*n));
                Console.WriteLine(n + "cubed is " + (n*n*n));
            }
        }
    }
}
