using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Temperature
{
    public class Celsius : Temp
    {
        public Units Units { get; set; } = Units.Celsius;
        public double Degrees { get; set; }

        public override double ConvertToTemperature(Units units, double inputDegrees)
        {
            double finalDegrees;

            switch (units)
            {
                case Units.Fahrenheit:
                    finalDegrees = ((inputDegrees + 32) * 1.8);
                    break;
                case Units.Celsius:
                    finalDegrees = inputDegrees;
                    break;
                case Units.Kelvins:
                    finalDegrees = inputDegrees + 273.15;
                    break;
                default:
                    finalDegrees = 0.0;
                    break;
            }

            return finalDegrees;
        }
    }
}
