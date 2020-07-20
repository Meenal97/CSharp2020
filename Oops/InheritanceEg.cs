using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
    public class ParentClassOne
    {
        public ParentClassOne()
        {
            Console.WriteLine("Parent Class Constructer");
        }

        public ParentClassOne(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class DerivedClassOne : ParentClassOne
    {
        public DerivedClassOne() : base("Dervied class controlling base class constructer")
        {
            Console.WriteLine("Child Class Constructer");
        }
    }
}
