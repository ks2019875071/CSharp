using System;

namespace _0329
{
    class AnotherBlockApp
    {
        static void Main(string[] args)
        {
            int x = 1;
            { //int x = 1; //error
                int y = 2;
                Console.WriteLine("Block 1 : x = " + x + ", y = " + y);
            }
            {
                int y = 3;
                Console.WriteLine("Block 2 : x= " + x + ", y = " + y);
            }
        }
    }
}
