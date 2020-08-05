using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    public class Customer67 :  IComparable<Customer67>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


       public int CompareTo(Customer67 other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else return 0;
        }
    }
}
