using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
    public class Name
    {
        private string n;
        
        public Name()
        {
            this.n = "No name";
        }

        public Name(string name)
        {
            this.n = name;
        }
        public void printName()
        {
            Console.WriteLine("Name  is {0} ", this.n);
        }
    }
}
