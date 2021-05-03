using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Calculator.Data
{
    public abstract class Temp
    {
        public Units Units { get; set; }
        public double Degrees { get; set; }

        public abstract double ConvertToTemperature(Temp temp);
    }
}
