using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of its category.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can't live without this product.";

            string[] events = new string[6];
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles. I am happy of the results!";
            events[3] = "I cannot believe but now I feel awesome.";
            events[4] = "Try it yourself, I am very satisfied.";
            events[5] = "I feel great!";

            string[] authors = new string[8];
            authors[0] = "Diana";
            authors[1] = "Petya";
            authors[2] = "Stella";
            authors[3] = "Elena";
            authors[4] = "Katya";
            authors[5] = "Iva";
            authors[6] = "Annie";
            authors[7] = "Eva";

            string[] cities = new string[5];
            cities[0] = "Burgas";
            cities[1] = "Sofia";
            cities[2] = "Plovdiv";
            cities[3] = "Varna";
            cities[4] = "Ruse";

            int printCount = int.Parse(Console.ReadLine());

            Random Numbers = new Random();

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine($"{phrases[Numbers.Next(phrases.Length - 1)]} {events[Numbers.Next(events.Length - 1)]} {authors[Numbers.Next(authors.Length - 1)]} - {cities[Numbers.Next(cities.Length - 1)]}");
            }
        }
    }
}
