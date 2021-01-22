using System;
using System.Collections.Generic;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);

                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);

                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);

                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Car car = new Car();
                car.Model = model;
                car.Engine.Speed = engineSpeed;
                car.Engine.Power = enginePower;
                car.Cargo.Weight = cargoWeight;
                car.Cargo.Type = cargoType;
                car.Tires[0].Pressure = tire1Pressure;
                car.Tires[0].Age = tire1Age;
                car.Tires[1].Pressure = tire2Pressure;
                car.Tires[1].Age = tire2Age;
                car.Tires[2].Pressure = tire3Pressure;
                car.Tires[2].Age = tire3Age;
                car.Tires[3].Pressure = tire4Pressure;
                car.Tires[3].Age = tire4Age;

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    bool lowPressureTire = false;
                    foreach (var tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            lowPressureTire = true;
                            break;
                        }
                    }
                    if (car.Cargo.Type == "fragile" && lowPressureTire == true)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
