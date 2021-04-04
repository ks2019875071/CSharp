using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            
            int index;
            for (index = 2; index < num; index++)
            {
                if (num % index == 0) //2 이상의 수로 나눠 소수인지 검사
                {
                    Console.WriteLine("{0}는 소수가 아닙니다", num);
                    break;
                }
            }
            if (index == num) //자기자신이 아닌 수를 모두 나눴는데 안되면 소수로 판정
                Console.WriteLine("{0}는 소수입니다", num);
        }
    }
}