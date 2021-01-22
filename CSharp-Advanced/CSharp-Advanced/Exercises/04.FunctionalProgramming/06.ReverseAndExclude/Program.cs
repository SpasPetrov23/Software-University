using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = n => n % divider == 0;
            Action<List<int>> removeDivisible = collection => collection.RemoveAll(isDivisible);
            Action<List<int>> reverseList = collection => collection.Reverse();
            Action<List<int>> printList = collection => Console.Write(string.Join(" ", collection));

            removeDivisible(input);
            reverseList(input);
            printList(input);
        }
    }
}
