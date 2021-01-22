using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string[]> printNames = a => Console.WriteLine(string.Join(Environment.NewLine, a));

            printNames(names);
        }
    }
}
