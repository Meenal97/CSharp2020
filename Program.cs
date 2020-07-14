using CSharpBasic.Oops;
using System;
using System.IO;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Polymorphism
            BaseClass b = new DerivedClass();
            b.print();
            #endregion


            BaseClass2 b2 = new DerivedClass2();
            b2.print();
        }
    }
}
