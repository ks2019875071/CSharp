﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class WhileStApp
    {

        static void Main(string[] args)
        {
            int i, n;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            i = 1;
            while (i <= n)
            {
                h = h + 1/(double)i;
                i++;
            }
            Console.WriteLine("n = {0}, h = {1}", n, h);
        }
    }
}
