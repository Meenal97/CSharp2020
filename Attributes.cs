﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;


namespace CSharpBasic
{
    public class Attributess
    {
        [Obsolete("Use Add with list on integers")]
        public int Calculator(int Fn, int Sn)
        {
            return Fn + Sn;
        }
        public int Calculator(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int Number in Numbers)
            {
                Sum += Number;
            }
            return Sum;
        }
    }
}
