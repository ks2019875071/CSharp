using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class CalculatorApp
    {

        static void Main(string[] args)
        {
            int x, y, r = 0;
            char opr;

            Console.WriteLine("Enter an operator & two numbers = ");
            opr = (char)Console.Read();
            x = Console.Read() - '0';
            y = Console.Read() - '0';
            //+ 7 8 이렇게 띄어 쓰거나
            // 2자리 이상인 숫자를 인식 못한다.

            switch (opr) //연산자
            {
                case '+': r = x + y;
                    Console.WriteLine(x + "+" + y + "=" + r); break;

                case '-': r = x - y;
                    Console.WriteLine(x + " - " + y + " = " + r); break;

                case '*': r = x * y;
                    Console.WriteLine(x + " * " + y + " = " + r); break;

                case '/': r = x / y;
                    Console.WriteLine(x + " / " + y + " = " + r); break;

                default: Console.WriteLine("Illegal operator "); break;
            }
        }
    }
}
