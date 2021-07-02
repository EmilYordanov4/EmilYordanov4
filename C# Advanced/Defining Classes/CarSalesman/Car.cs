using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public override string ToString()
        {
            return
                $"{Model}:" + Environment.NewLine +
            $"  {Engine.Model}:" + Environment.NewLine +
            $"    Power: {Engine.Power}" + Environment.NewLine +
            $"    Displacement: {Engine.Displacement}" + Environment.NewLine +
            $"    Efficiency: {Engine.Efficiency}" + Environment.NewLine +
            $"  Weight: {Weight}" + Environment.NewLine +
            $"  Color: {Color}";
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; } = "n/a";
        public string Color { get; set; } = "n/a";
        
    }
}
