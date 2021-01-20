using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[] input;
            string[] firstHalf = new string[rows];
            string[] secondHalf = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    firstHalf[i] = input[0];
                    secondHalf[i] = input[1];
                }
                else if (true)
                {
                    firstHalf[i] = input[1];
                    secondHalf[i] = input[0];
                }
            }

            foreach (var number in firstHalf)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            foreach (var number in secondHalf)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
