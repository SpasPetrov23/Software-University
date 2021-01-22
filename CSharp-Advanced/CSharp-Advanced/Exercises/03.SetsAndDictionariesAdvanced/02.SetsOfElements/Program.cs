using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengths = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int N = lengths[0];
            int M = lengths[1];

            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nSet.Add(number);
            }

            for (int i = 0; i < M; i++)
            {
                int number = int.Parse(Console.ReadLine());
                mSet.Add(number);
            }

            Console.WriteLine(String.Join(" ", nSet.Intersect(mSet)));

        }
    }
}
