using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = int.Parse(Console.ReadLine());
            long secondNumber = int.Parse(Console.ReadLine());

            long firstNumberFactorial = GetFactorial(firstNumber);
            long secondNumberFactorial = GetFactorial(secondNumber);

            double finalResult = (double)firstNumberFactorial / secondNumberFactorial;
            Console.WriteLine($"{finalResult:f2}");
        }

        private static long GetFactorial(long number)
        {
            long factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
