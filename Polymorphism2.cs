using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    public class EmployeeOne
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public virtual string PrintFullName()
        {
            return _firstName + " " + _lastName;
        }
    }

    public class PartTimeEmployee : EmployeeOne
    {
        public override string PrintFullName()
        {
            return _firstName + " " + _lastName + " - PartTime Employee";
        }
    }

    public class FullTimeEmployee : EmployeeOne
    {
        public override string PrintFullName()
        {
            return _firstName + " " + _lastName + " - FullTime Employee";
        }
    }


}
