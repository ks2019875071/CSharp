using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<10)
            // { 
            //Console.WriteLine("{0}: Hello C#", i);
            //i++;
            //}

            int j = 0;
            do
            {
                Console.WriteLine("{0} : Hello C#", j);
                j++;
            } while (j < 10);

            for (int k=0; k<10; k++)
                Console.WriteLine("{0}: Hello C#", k);
        }
    }
}
