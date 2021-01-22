using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var evenNumbers = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!evenNumbers.ContainsKey(number))
                {
                    evenNumbers.Add(number, 1);
                }
                else
                {
                    evenNumbers[number]++;
                }
            }

            foreach (var number in evenNumbers)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
