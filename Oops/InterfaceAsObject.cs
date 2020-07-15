using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{

        interface IA
        {
            void print();
        }
        interface IB
        {
            void print();
        }
        class classAB : IA, IB
        {
            void IA.print()
            {
                Console.WriteLine("Interface A, Class AB");
            }

            void IB.print()
            {
                Console.WriteLine("Interface B, Class AB");
            }
        }
    
}
