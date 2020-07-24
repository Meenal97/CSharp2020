using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.PartialClasses
{
    public partial class PartialClass
    {
        partial void SamplePartialMethodOne();
        partial void SamplePartialMethodTwo();
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
            SamplePartialMethodOne();
            SamplePartialMethodTwo();//Won't get a error if partial method is not implemented.
        }
    }
}
