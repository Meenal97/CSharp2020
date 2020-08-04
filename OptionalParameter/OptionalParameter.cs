using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic.OptionalParameter
{
    public class OptionalParameter1
    {
        public static int AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            if(restOfNumbers != null)
            {
                int result = firstNumber + secondNumber;
                foreach(int i in restOfNumbers)
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
