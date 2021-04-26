using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _0426
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("do BaseClass Task.");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            base.MethodA();
            Console.WriteLine("do DerivedClass Task.");
        }
    }

    class AddendumApp
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.MethodA();
        }
    }
}