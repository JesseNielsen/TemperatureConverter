using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Temperature
{
    public class Celsius : Temp
    {
        public string Name { get; set; } = "Celsius";
        public string Units { get; set; }
        public double Degrees { get; set; }

        public override Temp ConvertTemperature()
        {
            throw new NotImplementedException();
        }
    }
}
