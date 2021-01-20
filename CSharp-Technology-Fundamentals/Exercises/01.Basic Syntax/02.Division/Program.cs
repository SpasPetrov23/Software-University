using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 10 == 0 && number >= 10)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (number % 7 == 0 && number >= 7)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0 && number >= 6)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (number % 3 == 0 && number >= 3)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0 && number >= 2)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
