using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Stack<int>();
            int clothesSum = 0;

            int rackCapacity = 0;
            int racksCount = 1;

            //----------------------------

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            rackCapacity = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                box.Push(input[i]);
            }

            while (box.Count > 0)
            {
                clothesSum += box.Peek();
                if (clothesSum < rackCapacity)
                {
                }
                else if (clothesSum == rackCapacity)
                {
                    if (box.Count > 0)
                    {
                        racksCount++;
                        clothesSum = 0;
                    }
                }
                else if (clothesSum > rackCapacity)
                {
                    racksCount++;
                    clothesSum = 0;
                    clothesSum += box.Peek();
                }
                box.Pop();
            }
            Console.WriteLine(racksCount);

        }
    }
}
