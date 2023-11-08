using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                engines.Add(GetNewEngineData(engineInfo));
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                cars.Add(GetNewCarData(carInfo,engines));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static Car GetNewCarData(string[] carInfo, List<Engine> engines)
        {
            Engine engine = engines.Find(e => e.Model == carInfo[1]);
            Car car = new Car(carInfo[0], engine);

            if (carInfo.Length > 2)
            {
                int weight;
                bool isDigit = int.TryParse(carInfo[2], out weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carInfo[2];
                }
                if (carInfo.Length >3)
                {
                    car.Color = carInfo[3];
                }
            }
            return car;

        }

        public static Engine GetNewEngineData(string[] engineInfo)
        {
            string model = engineInfo[0];
            int power = int.Parse(engineInfo[1]);

            Engine engine = new Engine(model, power);
            if (engineInfo.Length > 2)
            {
                int displacement;

                bool isDigit = int.TryParse(engineInfo[2], out displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineInfo[2];
                }
                if (engineInfo.Length > 3)
                {
                    engine.Efficiency = engineInfo[3];
                }
            }
            return engine;

        }
    }
}
