using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintMatrixWithGivenNumber(number);
        }

        private static void PrintMatrixWithGivenNumber(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int column = 0; column < number; column++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
