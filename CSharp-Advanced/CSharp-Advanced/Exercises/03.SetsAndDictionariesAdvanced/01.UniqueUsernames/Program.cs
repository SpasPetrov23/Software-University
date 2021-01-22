using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());

            var collection = new Dictionary<string, int>();

            for (int i = 0; i < namesCount; i++)
            {
                string name = Console.ReadLine();
                if (!collection.ContainsKey(name))
                {
                    collection.Add(name, 0);
                }
            }

            foreach (var name in collection)
            {
                Console.WriteLine(name.Key);
            }
        }
    }
}
