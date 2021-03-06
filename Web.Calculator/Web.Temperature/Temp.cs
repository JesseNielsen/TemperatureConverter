using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Temperature
{
    public abstract class Temp
    {
        public Units Units { get; set; }
        public double Degrees { get; set; }

        public abstract double ConvertToTemperature(Units units, double inputDegrees);
    }
}
