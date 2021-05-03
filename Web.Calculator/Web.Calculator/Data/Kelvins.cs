using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Calculator.Data
{
    public class Kelvins : Temp
    {
        public Units Units { get; } = Units.Kelvins;
        public double Degrees { get; set; }
        public Kelvins()
        {

        }
        public Kelvins(double degrees)
        {
            this.Degrees = degrees;
        }

        public override double ConvertToTemperature(Temp temp)
        {
            double finalDegrees;

            switch (temp.Units)
            {
                case Units.Fahrenheit:
                    finalDegrees = ((temp.Degrees - 273.15) * 1.8) + 32;
                    break;
                case Units.Celsius:
                    finalDegrees = temp.Degrees - 273.15;
                    break;
                case Units.Kelvins:
                    finalDegrees = temp.Degrees;
                    break;
                default:
                    finalDegrees = 0.0;
                    break;
            }

            return finalDegrees;
        }
    }
}
