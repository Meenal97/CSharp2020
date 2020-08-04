using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.OptionalParameter
{
    public  class DefualtParameter
    {
        public static int AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            if (restOfNumbers != null)
            {
                int result = firstNumber + secondNumber;
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
                return result;
            }
            else
            {
                return firstNumber + secondNumber;
            }
        }
    }
}
