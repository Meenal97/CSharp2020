using CSharpBasic.Oops;
using System;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BaseClass b = new DerivedClass();
            b.print();
        }
    }
}
