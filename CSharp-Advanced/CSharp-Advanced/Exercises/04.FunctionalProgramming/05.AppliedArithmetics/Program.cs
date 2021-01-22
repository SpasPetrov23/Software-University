using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Func<int, int> add = n => n + 1;
            Func<int, int> subtract = n => n - 1;
            Func<int, int> multiply = n => n * 2;
            Action<int[]> print = nums => Console.WriteLine(String.Join(" ", nums));

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtract).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                command = Console.ReadLine();
            }
        }
    }
}
