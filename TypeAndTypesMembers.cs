using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    public  class TypeAndTypesMembers
    {
        // 3 private fields
        private int _ID;
        private string _firstName;
        private string _lastName;

        // 3 public properties
        public int ID
        {
           set { _ID = value; }
           get { return _ID; }
        }


        public string Firstname
        {
            set { _firstName = value; }
            get { return _firstName; }
        }

        public string Lastname
        {
            set { _lastName = value; }
            get { return _lastName; }
        }

        // 1 public method
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
    }
}
