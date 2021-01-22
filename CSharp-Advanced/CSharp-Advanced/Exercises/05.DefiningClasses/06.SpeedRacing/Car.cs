using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        //private string model;
        //private double fuelAmount;
        //private double fuelConsumptionPerKM;

        public Car()
        {

        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKM)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKM = fuelConsumptionPerKM;
            this.TravelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKM { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            double consumedFuel = FuelConsumptionPerKM * distance;
            if (FuelAmount >= consumedFuel)
            {
                FuelAmount -= consumedFuel;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
