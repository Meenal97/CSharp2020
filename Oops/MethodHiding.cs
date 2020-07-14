﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
    public class BaseClass2
    {
        public void print()
        {
            Console.WriteLine("Base Class");
        }
    }

    public class DerivedClass2 : BaseClass2
    {
        public new void print()
        {
            Console.WriteLine("Base Class");
        }
    }
}
