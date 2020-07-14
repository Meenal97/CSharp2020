using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{

        public class BaseClass3
        {
            public virtual void print()
            {
                Console.WriteLine("Base Class");
            }

        }

        public class DerivedClass3 : BaseClass3
        {
            public override void print()
            {
                Console.WriteLine("Derived Class");
            }
        }
    
}
