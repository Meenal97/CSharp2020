using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
    public class PropertiesInCsharp
    {
        private int passMarks = 35;
        private string name;
        private int ID;

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("No Name");
                }
                this.name = value;
            }

            get
            {
                return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
            }
        }

        public int PassMarks
        {
            get
            {
                return this.passMarks;
            }
        }

        public int Id
        {

            set
            {
                if (value <= 0)
                {
                    throw new Exception("ID cannot be zero");
                }
                this.ID = value;
            }
            get
            {
               return  this.ID;
            }
        }
    }
}
