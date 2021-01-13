using System;

namespace My_personal_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter first value.");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter second value.");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            var operations = new ArithmeticOperations();

            var resultSum = operations.Sum(firstValue, secondValue);
            Console.WriteLine(resultSum);

            var resultMinus = operations.Minus(firstValue, secondValue);
            Console.WriteLine(resultMinus);

            var resultMultiplication = operations.Multiplication(firstValue, secondValue);
            Console.WriteLine(resultMultiplication);

            var resultDivide = operations.Divide(firstValue, secondValue);
            Console.WriteLine(resultDivide);
        }
    }
}
