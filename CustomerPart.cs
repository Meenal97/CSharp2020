using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    public partial class CustomerPart
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            set
            {
                _FirstName = value;
            }
            get
            {
                return _FirstName;
            }
        }

        public string LastName { get => _LastName; set => _LastName = value; }


    }
}
