using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08.CarSalesman
{
    internal class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            //Displacement = 0;
            //Efficiency = "n/a";
        }
        //public Engine(string model, int power, int displacement) : this(model, power)
        //{
        //    this.Displacement = displacement;
        //}
        //public Engine(string model, int power, string efficiency) : this(model, power)
        //{
        //    this.Efficiency = efficiency;
        //}

        //public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        //{
        //    this.Displacement = displacement;
        //    this.Efficiency = efficiency;
        //}

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            string efficiency = Efficiency == null ? "n/a" : Efficiency;

            string result = $"{Model}:{Environment.NewLine}" +
                $"    Power: {Power}{Environment.NewLine}" +
                $"    Displacement: {displacement}{Environment.NewLine}" +
                $"    Efficiency: {efficiency}";
            return result;
        }
    }
}
