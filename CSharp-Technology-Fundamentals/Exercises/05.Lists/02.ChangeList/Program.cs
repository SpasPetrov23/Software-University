using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandParts = command.Split();
                if (commandParts[0] == "Delete")
                {
                    int elementToRemove = int.Parse(commandParts[1]);
                    numbers.RemoveAll(element => element == elementToRemove);
                }
                else if (commandParts[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commandParts[2]), int.Parse(commandParts[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
