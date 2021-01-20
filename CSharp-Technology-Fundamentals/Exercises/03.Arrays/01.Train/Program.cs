using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int passengers = 0;
            int totalPassengers = 0;
            string output = "";
            for (int i = 0; i < wagonsCount; i++)
            {
                passengers = int.Parse(Console.ReadLine());
                totalPassengers += passengers;
                output += passengers + " ";
            }
            Console.WriteLine(output);
            Console.WriteLine(totalPassengers);
        }
    }
}
