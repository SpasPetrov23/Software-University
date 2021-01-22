using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Func<int, int> func = PrintLowestNumber;

            func(input.Min());

        }

        static int PrintLowestNumber(int input)
        {
            Console.WriteLine(input);
            return input;
        }
    }
}
