using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403
{
    class InfiniteLoop
    {
            // break의 사용
            // 첫날 1000원에서 시작해서 매일 2배씩 저금을 늘리면 며칠째 백만원을 넘길 수 있나?
            // 1, 2, 3, 4, 5, ...
            // 1, 2, 4, 8, 16, ...
        static void Main(string[] args)
        {
            int sum = 0;
            int days = 1;
            int money = 1000;

            while (true)
            {
                sum += money; //Saving
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);

                if (sum >= 1000000) //100만원 달성
                    break;

                days++;
                money *= 2; //저금 늘림
            }

            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);




            //2번째 방법
            //sum = 0; //days = 1; //money = 1000;
            for (sum = 0, days = 1, money = 1000; ; days++, money *= 2)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);
                if (sum >= 1000000)
                    break;
            }

            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);
        }
    }
}