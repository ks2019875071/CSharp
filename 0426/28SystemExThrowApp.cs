using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _0426
{
    class SystemExThrow
    {
        public static void Exp(int ptr)
        {
            if (ptr == 0)
                throw new NullReferenceException();
        }
    }
    class SystemExThrowApp
    {
        public static void Main()
        {
            int i = 0;
            SystemExThrow.Exp(i);
        }
    }
}