using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07.RawData
{
    internal class Car
    {
        public Car(string[] carInfo)
        {
            this.Model = carInfo[0];

            int engineSpeed = int.Parse(carInfo[1]);
            int enginePower = int.Parse(carInfo[2]);
            this.Engine = new Engine(engineSpeed,enginePower);

            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];
            this.Cargo = new Cargo(cargoType, cargoWeight);

            this.Tires = new Tire[4];
            int inputIndexCounter = 5;
            for (int i = 0; i < 4; i++)
            {
                double pressure = double.Parse(carInfo[inputIndexCounter++]);
                int age = int.Parse(carInfo[inputIndexCounter++]);
                this.Tires[i] = new Tire(age, pressure);
            }
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }
    }
}
