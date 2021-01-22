using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();
            int stackMinimal = int.MaxValue;

            //---------------------------------------

            foreach (var number in numbers)
            {
                queue.Enqueue(number);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                foreach (var item in queue)
                {
                    if (item < stackMinimal)
                    {
                        stackMinimal = item;
                    }
                }
                if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stackMinimal);
                }
            }

        }
    }
}
