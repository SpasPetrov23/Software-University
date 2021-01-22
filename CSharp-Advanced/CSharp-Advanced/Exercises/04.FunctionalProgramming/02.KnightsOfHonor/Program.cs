using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            Action<string> action = PrintNames;

            for (int i = 0; i < input.Length; i++)
            {
                action(input[i]);
            }

        }

        static void PrintNames(string input)
        {
            Console.WriteLine($"Sir {input}");
        }
    }
}
