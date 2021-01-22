using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);
            Console.WriteLine($"{pesho.Name} {pesho.Age}");
        }
    }
}
