using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.Oops
{
 
        interface A
        {
            void print();
        }

        interface B
        {
            void details();
        }


        public class classA : A, B
        {
            public void details()
            {
                Console.WriteLine("Implementing Interface B in class classA");
            }

            public void print()
            {
                Console.WriteLine("Implementing Interface A in class classA");
            }
        }
    
}
