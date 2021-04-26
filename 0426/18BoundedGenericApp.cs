using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _0426
{
    class GenericType<T> where T : SystemException
    {
        private T value;
        public GenericType(T v)
        {
            value = v;
        }
        override public String ToString()
        {
            return "Type is " + value.GetType();
        }
    }

    public class BoundedGenericApp
    {
        static void Main()
        {
            GenericType<NullReferenceException> gNullEx = new GenericType<NullReferenceException>(new NullReferenceException());
            GenericType<IndexOutOfRangeException> gIndexEx = new GenericType<IndexOutOfRangeException>(new
            IndexOutOfRangeException());
            // GenericType<String> gString = new GenericType<String>("Error"); //에러
            Console.WriteLine(gNullEx.ToString());
            Console.WriteLine(gIndexEx.ToString());
        }
    }
}