using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class ReadIntegerApp
    {
        static int ReadInt()
        {
            char ch;
            int n = 0;
            
            while (!char.IsDigit(ch = (char)Console.Read())) ; //when ch != digit

            do
            {
                n = n * 10 + (ch - '0');
                ch = (char)Console.Read();
            } while (char.IsDigit(ch)); //when ch == digit
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** input data : ");
            Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt()); //digit 2개를 읽음
        }
    }
}
