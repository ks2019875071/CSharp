using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class NestedIfApp
    {

        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter the day number 1~7 : ");
            day = (int)Console.Read() - '0';
            //질문 : 왜 명시적 형변환을 사용하는가? 앞에선 안썼는데

            if (day == 1) Console.WriteLine("Sunday");
            else if (day == 2) Console.WriteLine("Monday");
            else if (day == 3) Console.WriteLine("Tuesday");
            else if (day == 4) Console.WriteLine("Wednesday");
            else if (day == 5) Console.WriteLine("Thursday");
            else if (day == 6) Console.WriteLine("Friday");
            else if (day == 7) Console.WriteLine("Saturday");
            else Console.WriteLine("Illegal day");
        }
    }
}
