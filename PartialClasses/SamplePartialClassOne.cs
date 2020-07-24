using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.PartialClasses
{
    public interface IACustomer
    {
        void CustMethod();
    }
    public partial class SamplePartial : IACustomer
    {
        public void CustMethod()
        {
            Console.WriteLine("Customer Method, Partial Class Two, Interface IACustomer");
        }

        public void DetailCust()
        {
            Console.WriteLine("DetailCust Method, Partial Class Two, Interface IBCustomer");
        }
    }
}
