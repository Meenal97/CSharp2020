using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.PartialClasses
{
    public interface IBCust
    {
        void DetailCust();
    }
    public partial class SamplePartial : IBCust
    {
    }
}
