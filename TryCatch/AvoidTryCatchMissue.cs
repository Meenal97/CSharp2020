using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpBasic.TryCatch
{
    public  class AvoidTryCatchMissue
    {
        public void Divide()
        {
            try
            {
                int Numerator;
                Console.WriteLine("Enter numerator ");
                bool IsValidNumerator = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (IsValidNumerator)
                {
                    int Denomirator;
                    Console.WriteLine("Enter Denomirator");
                    bool IsDenomirator = Int32.TryParse(Console.ReadLine(), out Denomirator);
                    if (IsDenomirator && Denomirator != 0)
                    {
                        float result = Numerator / Denomirator;
                        Console.WriteLine("Result {0}", result);
                    }
                    else
                    {
                        if (Denomirator == 0)
                        {
                            Console.WriteLine("Denomiarator Can Not be zero");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
