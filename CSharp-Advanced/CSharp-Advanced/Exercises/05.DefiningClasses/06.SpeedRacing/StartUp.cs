using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKM = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKM);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] data = command.Split(" ");
                string travelModel = data[1];
                double travelDistance = double.Parse(data[2]);

                foreach (var car in cars)
                {
                    if (car.Model == travelModel)
                    {
                        car.Drive(travelDistance);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }

        }
    }
}
