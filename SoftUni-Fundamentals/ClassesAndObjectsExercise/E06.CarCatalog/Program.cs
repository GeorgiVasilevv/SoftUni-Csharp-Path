using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.CarCatalog
{
    class Car
    {
        public Car(string type, string model, string color, int HP)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HP = HP;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.HP}";
            return vehicleStr;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> catalog = new List<Car>();
            double carHp = 0, truckHp = 0;
            int carCounter = 0, truckCounter = 0;

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] tokens = cmd.Split().ToArray();
                string typeOfVehicle = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int HP = int.Parse(tokens[3]);

                if (typeOfVehicle == "car")
                {
                    carHp += HP;
                    carCounter++;
                }
                else if (typeOfVehicle == "truck")
                {
                    truckHp+=HP;
                    truckCounter++;
                }
                Car car = new Car(typeOfVehicle, model, color, HP);
                catalog.Add(car);
                cmd = Console.ReadLine();
            }
            string cmd2 = Console.ReadLine();
            while (cmd2 != "Close the Catalogue")
            {
                Console.WriteLine(catalog.Find(x => x.Model == cmd2));
                cmd2 = Console.ReadLine();
            }

            double averageCarsHorsepower = carHp / carCounter;
            double averageTrucksHorsepower = truckHp / truckCounter;

            if (carCounter==0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            }
            if (truckCounter > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
