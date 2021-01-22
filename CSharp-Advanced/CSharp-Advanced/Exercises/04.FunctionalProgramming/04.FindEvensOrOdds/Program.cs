using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int startValue = array[0];
            int endValue = array[1];
            string command = Console.ReadLine();

            Func<int, int> func = PrintLowestNumber;

            for (int i = startValue; i <= endValue; i++)
            {
                if (command == "odd" && i % 2 != 0)
                {
                    func(i);
                }
                else if (command == "even" && i % 2 == 0)
                {
                    func(i);
                }
            }

        }

        static int PrintLowestNumber(int input)
        {
            Console.Write($"{input} ");
            return input;
        }
    }
}
