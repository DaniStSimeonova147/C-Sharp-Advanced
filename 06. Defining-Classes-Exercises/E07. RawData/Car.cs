using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            if (tires.Length != 4)
            {
                throw new InvalidOperationException("Tires can not be no more neither less than 4 !");
            }

            this.Model = model;

            this.Engine = engine;

            this.Cargo = cargo;

            this.Tires = tires;
        }

    }
}
