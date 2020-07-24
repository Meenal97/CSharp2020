using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    public partial  class CustomerPart
    {
        public string GetFullNameCust()
        {
            return _FirstName + " , " + _LastName + " .";
        }
    }
}
