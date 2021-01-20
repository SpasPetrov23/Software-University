using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            int number = FirstNumber;
            int lastDigit = 0;

            int factorial = 1;
            int factorialSum = 0;

            while (number > 0)
            {
                factorial = 1;
                lastDigit = number % 10;

                if (lastDigit != 0)
                {
                    for (int i = 1; i <= lastDigit; i++)
                    {
                        factorial *= i;
                    }
                }
                factorialSum += factorial;

                number = number / 10;
            }
            if (factorialSum == FirstNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
