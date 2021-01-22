using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            var periodicTable = new SortedSet<string>();
            for (int i = 0; i < commands; i++)
            {
                string[] elements = Console.ReadLine().Split(" ").ToArray();

                foreach (var element in elements)
                {
                    periodicTable.Add(element);
                }
            }

            Console.WriteLine(String.Join(" ", periodicTable));
        }
    }
}
