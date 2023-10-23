using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Queue<string> carsForService = new Queue<string>(input);

            Stack<string> servedCars = new Stack<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Service" && carsForService.Count > 0)
                {
                    string currentCar = carsForService.Dequeue();
                    Console.WriteLine($"Vehicle {currentCar} got served.");
                    servedCars.Push(currentCar);
                }
                else if (command.Contains("CarInfo"))
                {
                    string[] tokens = command.Split("-");
                    string carModel = tokens[1];
                    if (carsForService.Contains(carModel))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }


                command = Console.ReadLine();
            }

            if (carsForService.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsForService)}");
            }
            if (servedCars.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
            }

        }
    }
}
