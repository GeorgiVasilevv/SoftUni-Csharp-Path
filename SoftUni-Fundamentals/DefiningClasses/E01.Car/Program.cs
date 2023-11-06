using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Car car = new Car();

            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 2;
            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());

            List<Tire[]> tirePacks = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = command.Split();
                Tire[] singleTires = new Tire[4];
                int indexCounter = 0;
                for (int i = 0; i < 4; i++)
                {
                    int year = int.Parse(tokens[indexCounter++]);
                    double pressure = double.Parse(tokens[indexCounter++]);
                    singleTires[i] = new Tire(year, pressure);

                }
                tirePacks.Add(singleTires);
            }

            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = command.Split();
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = command.Split();

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Tire[] currentCarTires = tirePacks[tiresIndex];
                Engine currentCarEnginge = engines[engineIndex];

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, currentCarEnginge, currentCarTires));
            }

            List<Car> specialCars = cars
                .FindAll(c => c.Year >= 2017
                && c.Engine.HorsePower > 330 
                && c.Tires.Select(t => t.Pressure).Sum() >=9 
                && c.Tires.Select(t => t.Pressure).Sum() <=10 );

            foreach (Car car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
