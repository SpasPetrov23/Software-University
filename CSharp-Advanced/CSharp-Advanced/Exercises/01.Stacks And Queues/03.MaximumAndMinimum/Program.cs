using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            int min = int.MinValue;
            int max = int.MaxValue;

            int command = 0;
            int value = 0;

            while (rows > 0)
            {
                rows--;
                int[] query = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                command = query[0];

                if (command == 1)
                {
                    value = query[1];
                    stack.Push(value);
                }
                else if (command == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                else
                {
                    break;
                }
            }
            string result = string.Join(", ", stack);
            Console.Write(result);
        }
    }
}
