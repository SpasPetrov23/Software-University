using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourceDict = new Dictionary<string, int>();
            string input = "";

            int lines = 0;
            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resourceDict.ContainsKey(input))
                {
                    resourceDict[input] += quantity;
                }
                else
                {
                    resourceDict[input] = quantity;
                }
            }

            foreach (var item in resourceDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
