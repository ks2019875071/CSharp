using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403
{
    class UsingBreak
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; ; i++) //무기한 루프
            {
                sum += i;
                if (sum >= 10000)
                {
                    Console.WriteLine("1~{0}의 합 = {1}", i, sum);
                    break;
                }
            }


            //2번째 방법
            sum = 0;
            int index = 1;

            for (; sum < 10000; index++)
            {
                sum += index;
            }
            Console.WriteLine("1~{0}의 합 = {1}", index - 1, sum); //index++ 한번 더 하고 루프가 끝나므로
        }
    }
}