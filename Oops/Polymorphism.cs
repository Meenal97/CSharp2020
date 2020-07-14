using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
    public class BaseClass
    {
        public virtual void print()
        {
            Console.WriteLine("Base Class");
        }

    }

    public class DerivedClass : BaseClass
    {
        public override void print()
        {
            Console.WriteLine("Derived Class");
        }
    }

}
