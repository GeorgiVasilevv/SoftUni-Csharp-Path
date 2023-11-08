using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08.CarSalesman
{
    internal class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            this.Engine = engine;
            //Weight = 0;
            //Color = "n/a";
        }
        //public Car(string model, Engine engine, int weight) : this(model, engine)
        //{
        //    Weight = weight;
            
        //}
        //public Car(string model, Engine engine, string color) : this(model, engine)
        //{
        //    Color = color;
        //}
        //public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        //{
        //    Weight = weight;
        //    Color = color;
        //}

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string weight = Weight == 0 ? "n/a" : Weight.ToString();
            string color = Color == null ? "n/a" : Color;

            string result = $"{Model}:{Environment.NewLine}" +
                $"  {Engine.ToString()}{Environment.NewLine}" +
                $"  Weight: {weight}{Environment.NewLine}" +
                $"  Color: {color}";
            return result;
        }
    }
}
