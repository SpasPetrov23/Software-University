using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordInput = Console.ReadLine().Split().ToArray();
            var charDictionary = new Dictionary<char, int>();

            foreach (string word in wordInput)
            {
                foreach (char letter in word)
                {
                    if (charDictionary.ContainsKey(letter))
                    {
                        charDictionary[letter]++;
                    }
                    else
                    {
                        charDictionary[letter] = 1;
                    }
                }
            }

            foreach (var letter in charDictionary)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
