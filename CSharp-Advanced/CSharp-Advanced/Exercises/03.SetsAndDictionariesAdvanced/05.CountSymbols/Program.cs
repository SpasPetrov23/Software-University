using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var letterCounter = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (!letterCounter.ContainsKey(letter))
                {
                    letterCounter.Add(letter, 1);
                }
                else
                {
                    letterCounter[letter]++;
                }
            }

            foreach (var letter in letterCounter)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
