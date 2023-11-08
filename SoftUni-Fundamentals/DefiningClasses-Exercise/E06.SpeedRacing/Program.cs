using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionFor1km = double.Parse(tokens[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumptionFor1km));
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                string carModel = tokens[1];
                double distance = double.Parse(tokens[2]);
                Car currentCar = cars.Find(c => c.Model == carModel);
                currentCar.Drive(distance);

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
