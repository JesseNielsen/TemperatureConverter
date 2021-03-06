using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Temperature
{
    public class Fahrenheit : Temp
    {
        public Units Units { get; set; } = Units.Fahrenheit;
        public double Degrees { get; set; }

        public override double ConvertToTemperature(Units units, double inputDegrees)
        {
            double finalDegrees;

            switch (units)
            {
                case Units.Fahrenheit:
                    finalDegrees = inputDegrees;
                    break;
                case Units.Celsius:
                    finalDegrees = (inputDegrees - 32) / 1.8;
                    break;
                case Units.Kelvins:
                    finalDegrees = ((inputDegrees - 32) * 1.8) + 273.15;
                    break;
                default:
                    finalDegrees = 0.0;
                    break;
            }

            return finalDegrees;
        }
    }
}
