using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());
            string visitorType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double cost = 0.00;
            double price = 0.00;
            double totalPrice = 0.00;

            //First Type
            if (visitorType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price += 8.45 * visitors;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price += 9.80 * visitors;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price += 10.46 * visitors;
                }

                if (visitors >= 30)
                {
                    totalPrice = price * 0.85;
                }
                else
                {
                    totalPrice = price;
                }
            }

            //Second Type
            else if (visitorType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    cost = 10.90;
                    price += cost * visitors;
                }
                else if (dayOfWeek == "Saturday")
                {
                    cost = 15.60;
                    price += cost * visitors;
                }
                else if (dayOfWeek == "Sunday")
                {
                    cost = 16.00;
                    price += cost * visitors;
                }

                if (visitors >= 100)
                {
                    totalPrice = price - 10 * cost;
                }
                else
                {
                    totalPrice = price;
                }
            }

            //Third Type
            else if (visitorType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price += 15.00 * visitors;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price += 20.00 * visitors;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price += 22.50 * visitors;
                }

                if (visitors >= 10 && visitors <= 20)
                {
                    totalPrice = price * 0.95;
                }
                else
                {
                    totalPrice = price;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
