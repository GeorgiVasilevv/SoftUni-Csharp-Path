using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Car
    {

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance{ get; set; }

        public Car(string model, double fuelAmount, double fuelConsumprion)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumprion;
            this.TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            double fuelToUse = FuelConsumptionPerKilometer * distance;

            if (FuelAmount-fuelToUse <0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }
            FuelAmount -= fuelToUse;
            TravelledDistance += distance;
        }
    }
}
