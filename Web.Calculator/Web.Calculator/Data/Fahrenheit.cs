using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Calculator.Data
{
    public class Fahrenheit : Temp
    {
        public Units Units { get; } = Units.Fahrenheit;
        public double Degrees { get; set; }

        public Fahrenheit()
        {

        }
        public Fahrenheit(double degrees)
        {
            this.Degrees = degrees;
        }

        public override double ConvertToTemperature(Temp temp)
        {
            double finalDegrees;

            switch (temp.Units)
            {
                case Units.Fahrenheit:
                    finalDegrees = temp.Degrees;
                    break;
                case Units.Celsius:
                    finalDegrees = (temp.Degrees - 32) / 1.8;
                    break;
                case Units.Kelvins:
                    finalDegrees = ((temp.Degrees - 32) * 1.8) + 273.15;
                    break;
                default:
                    finalDegrees = 0.0;
                    break;
            }

            return finalDegrees;
        }
    }
}
