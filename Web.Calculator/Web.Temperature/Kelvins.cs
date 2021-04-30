using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Temperature
{
    public class Kelvins : Temp
    {
        public string Name { get; set; } = "Kelvins";
        public string Units { get; set; }
        public double Degrees { get; set; }

        public override Temp ConvertTemperature()
        {
            throw new NotImplementedException();
        }
    }
}
