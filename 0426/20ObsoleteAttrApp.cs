using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _0426
{
    class ObsoleteAttr
    {
        [Obsolete("경고, Obsolete Method입니다.")]
        public static void OldMethod()
        {
            Console.WriteLine("In the Old Method ...");
        }
        public static void NormalMethod()
        {
            Console.WriteLine("In the Normal Method ...");
        }
    }

    class ObsoleteAttrApp
    {
        static void Main()
        {
            ObsoleteAttr.OldMethod();
            ObsoleteAttr.NormalMethod();
        }
    }
}