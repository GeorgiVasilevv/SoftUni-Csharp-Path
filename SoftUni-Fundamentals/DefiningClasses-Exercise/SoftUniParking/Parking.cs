using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    internal class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            Cars = new List<Car>();
        }
        public int Count { get { return cars.Count; } }
        public List<Car> Cars { get { return cars; } set { cars = value; } }

        public string AddCar(Car car)
        {
            if (this.cars.Any(c=> c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count >= capacity) // may be >=
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!cars.Any(c=>c.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(cars.Find(c => c.RegistrationNumber == registrationNumber));
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar (string registrationNumber)
        {
            return this.cars.Find(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var regNum in registrationNumbers)
            {
                RemoveCar(regNum);
            }
        }
    }
}
