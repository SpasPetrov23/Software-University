using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int clothesAmount = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < clothesAmount; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var clothing in clothes)
                {
                    if (!wardrobe[color].ContainsKey(clothing))
                    {
                        wardrobe[color].Add(clothing, 0);
                    }

                    wardrobe[color][clothing]++;
                }
            }

            string[] lookingFor = Console.ReadLine().Split(" ");
            string desiredColor = lookingFor[0];
            string desiredClothing = lookingFor[1];

            foreach (var clothing in wardrobe)
            {
                Console.WriteLine($"{clothing.Key} clothes:");
                foreach (var item in clothing.Value)
                {
                    if (desiredColor == clothing.Key && desiredClothing == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }

        }
    }
}
