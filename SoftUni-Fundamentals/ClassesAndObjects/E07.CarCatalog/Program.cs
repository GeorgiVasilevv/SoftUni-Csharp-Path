using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.CarCatalog
{
    class Truck
    {
        
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; } // Migth Be Double

    }

    class Car
    {
        public Car(string brand, string model, int HP)
        {
            this.Brand = brand;
            this.Model = model;
            this.HP = HP;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Truck = new List<Truck>();
            this.Car = new List<Car>();
        }
        public List<Truck> Truck { get; set; }
        public List<Car> Car { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                string[] tokens = cmd.Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int hpOrWeight = int.Parse(tokens[3]);


                if (type == "Car")
                {
                    Car car = new Car(brand, model, hpOrWeight);
                    catalog.Car.Add(car);
                }
                else if (type == "Truck")
                {

                    Truck truck = new Truck(brand, model, hpOrWeight);
                    catalog.Truck.Add(truck);

                }

                cmd = Console.ReadLine();
            }

            if (catalog.Car.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car carList in catalog.Car.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HP}hp");
                }
            }
            if (catalog.Truck.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truckList in catalog.Truck.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }

        }
    }
}
