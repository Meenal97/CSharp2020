using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    public class OverideEquals
    {
         public  int i { get; set; }
        public int j { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(!(obj is OverideEquals))
            {
                return false;
            }
            return this.i == ((OverideEquals)obj).i && this.j == ((OverideEquals)obj).j;
        }

        public override int GetHashCode()
        {
            return this.i.GetHashCode() ^ this.j.GetHashCode();
        }
    }
}
