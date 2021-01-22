using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car()
        {
            Engine engine = new Engine();
            this.Engine = engine;

            Cargo cargo = new Cargo();
            this.Cargo = cargo;

            List<Tire> tires = new List<Tire>();
            this.Tires = tires;

            Tire tire1 = new Tire();
            tires.Add(tire1);

            Tire tire2 = new Tire();
            tires.Add(tire2);

            Tire tire3 = new Tire();
            tires.Add(tire3);

            Tire tire4 = new Tire();
            tires.Add(tire4);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }
    }
}
