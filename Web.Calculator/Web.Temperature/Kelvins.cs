using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Temperature
{
    public class Kelvins : Temp
    {
        public Units Units { get; set; } = Units.Kelvins;
        public double Degrees { get; set; }

        public override double ConvertToTemperature(Units units, double inputDegrees)
        {
            double finalDegrees;

            switch (units)
            {
                case Units.Fahrenheit:
                    finalDegrees = ((inputDegrees - 273.15) * 1.8) + 32;
                    break;
                case Units.Celsius:
                    finalDegrees = inputDegrees - 273.15;
                    break;
                case Units.Kelvins:
                    finalDegrees = inputDegrees;
                    break;
                default:
                    finalDegrees = 0.0;
                    break;
            }

            return finalDegrees;
        }
    }
}
