using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            var seniorPeople = new List<Person>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                if (person.Age > 30)
                {
                    seniorPeople.Add(person);
                }
            }

            foreach (var person in seniorPeople.OrderBy(a=>a.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
