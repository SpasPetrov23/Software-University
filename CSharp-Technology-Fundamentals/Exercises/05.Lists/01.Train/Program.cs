using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandParts = command.Split();
                if (commandParts[0] == "Add")
                {
                    wagons.Add(int.Parse(commandParts[1]));
                }
                else
                {
                    for (int wagon = 0; wagon < wagons.Count; wagon++)
                    {
                        if (wagons[wagon] + int.Parse(commandParts[0]) <= maxCapacity)
                        {
                            wagons[wagon] += int.Parse(commandParts[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
