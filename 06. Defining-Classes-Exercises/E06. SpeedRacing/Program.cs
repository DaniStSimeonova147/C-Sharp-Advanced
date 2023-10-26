using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cars = GetCars();

            DriveCars(cars);
            PrintCars(cars);
        }
        #region
        private static List<Car> GetCars()
        {
            List<Car> carsInfo = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                //"{model} {fuelAmount} {fuelConsumptionFor1km}"

                string currentModel = input[0];
                double currentFuleAmount = double.Parse(input[1]);
                double currentFuelConsumption = double.Parse(input[2]);

                carsInfo.Add(new Car(currentModel, currentFuleAmount, currentFuelConsumption));
            }

            return carsInfo;
        }

        private static void DriveCars(List<Car> cars)
        {
            //"Drive {carModel} {amountOfKm}"

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string model = input[1];
                double amountOfKm = double.Parse(input[2]);

                Car currentCar = cars.Where(c => c.Model == model).FirstOrDefault();

                if (currentCar != null)
                {
                    currentCar.Drive(amountOfKm);
                }

                input = Console.ReadLine().Split();
            }
        }

        private static void PrintCars(List<Car> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars
                .Select(c => $"{c.Model} {c.FuelAmount:f2} {c.TravelledDistance}")));
        }
        #endregion
    }
}
