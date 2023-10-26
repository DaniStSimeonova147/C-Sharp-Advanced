using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = GetCars();

            PrintCars(cars);
        }

        #region

        private static List<Car> GetCars()
        {
            int count = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType}
                //{ tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string[] input = Console.ReadLine().Split();

                string model = input[0];

                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));

                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);

                Tire[] tires = new Tire[]
                {
               new Tire (double.Parse(input[5]), int.Parse(input[6])),
               new Tire(double.Parse(input[7]), int.Parse(input[8])),
               new Tire(double.Parse(input[9]), int.Parse(input[10])),
               new Tire(double.Parse(input[11]), int.Parse(input[12])),
                };

                cars.Add(new Car(model, engine, cargo, tires));
            }

            return cars;
        }

        private static void PrintCars(List<Car> cars)
        {
            string command = Console.ReadLine();

            if (command == "fragile" )
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                    cars.Where(c => c.Tires.Where(t => t.Pressure < 1).FirstOrDefault() != null)
                    .Select(c => c.Model)));
            }
            else if (command == "flamable")
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                    cars.Where(c => c.Engine.Power > 250)
                    .Select(c => c.Model)));
            }

            //Console.WriteLine(string.Join(Environment.NewLine, cars
            //             .Where(c => c.Cargo.Type == command && command == "fragile"
            //                 ? c.Tires
            //                     .Where(t => t.Pressure < 1)
            //                     .FirstOrDefault() != null
            //                 : c.Engine.Power > 250)
            //             .Select(c => c.Model)));
        }

        #endregion
    }

    
}

