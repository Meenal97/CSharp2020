using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
    public  class GetterSetter
    {
        private int passMarks = 35;
        private string name;
        private int ID;
        public int GetPassMarks()
        {
            return this.passMarks; 
        }

        public void SetName(string name)
        {  
           if(string.IsNullOrEmpty(name))
            {
                throw new Exception("No Name");
            }
            this.name = name;
        }

        public string GetName()
        {
            return (string.IsNullOrEmpty(name)) ? "No Name" : this.name;
        }

        public void SetID(int id)
        {
            if(id <= 0)
            {
                throw new Exception("ID cannot be negative");
            }
            this.ID = id;
        }

        public int GetID()
        {
            return this.ID;
        }
    }
}
