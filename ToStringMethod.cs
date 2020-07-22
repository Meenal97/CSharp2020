using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    public  class ToStringMethod
    {
        public string FirstName;
        public string LastName;

        public override string ToString()
        {
            return FirstName + "," + LastName;
        }
    }
}
