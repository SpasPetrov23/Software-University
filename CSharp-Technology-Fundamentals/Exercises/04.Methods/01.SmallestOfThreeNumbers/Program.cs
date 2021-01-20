using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestOfThreeNumbers(firstNumber, secondNumber, thirdNumber));
        }

        private static int SmallestOfThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                int smallestNumber = firstNumber;
                return smallestNumber;
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                int smallestNumber = secondNumber;
                return smallestNumber;
            }
            else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
            {
                int smallestNumber = thirdNumber;
                return smallestNumber;
            }
            return firstNumber;
        }
    }
}
