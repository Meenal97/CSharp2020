using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CSharpBasic
{
    public  class NamedParameter
    {
        public static void test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("A {0}", a);
            Console.WriteLine("B {0}", b);
            Console.WriteLine("B {0}", c);
        }
    }
}
