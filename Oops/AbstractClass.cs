using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
   public abstract class abstractClass
    {
        public virtual void details()
        {
            Console.WriteLine("Details Method, Defined in abstract class");
        }
        public abstract void print();
    }

    public class studentclass : abstractClass
    {
        public override void print()
        {
            Console.WriteLine("Print Class");
        }

        public override void details()
        {
            Console.WriteLine("Details Method, Overriden ");
        }

    }
}
