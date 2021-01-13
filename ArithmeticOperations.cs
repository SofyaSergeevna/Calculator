using System;
using System.Collections.Generic;
using System.Text;

namespace My_personal_calculator
{
    public class ArithmeticOperations
    {
        public int Sum(int firstValue, int secondValue)
        {
            int result = firstValue + secondValue;
            return result;
        }
        
        public int Minus(int firstValue, int secondValue)
        {
            int result = firstValue - secondValue;
            return result;
        }

        public int Multiplication(int firstValue, int secondValue)
        {
            int result = firstValue * secondValue;
            return result;
        }

        public decimal Divide(int firstValue, int secondValue)
        {
            decimal result = Convert.ToDecimal(firstValue) / Convert.ToDecimal(secondValue);
            return result;
        }
    }
}
