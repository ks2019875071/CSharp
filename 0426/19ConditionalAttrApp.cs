#define CSHARP

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;


namespace _0426
{
    class ConditionalAttr
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }
        [Conditional("JAVA")]
        public static void JavaMethod()
        {
            Console.WriteLine("In the Java Method ...");
        }
    }

    class ConditionalAttrApp
    {
        static void Main()
        {
            ConditionalAttr.CsharpMethod();
            ConditionalAttr.JavaMethod();
        }
    }
}