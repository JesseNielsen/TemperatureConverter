using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Calculator.Data;

namespace Web.Calculator.Pages
{
    public partial class Index
    {
        public double InputDegrees { get; set; } = 0;
        public double OutputDegrees { get; set; } = 0;
        public string[] Units { get; } = new string[3] { "Celsius", "Fahrenheit", "Kelvins" };
        public string InputUnit { get; set; } = "Celsius";
        public string OutputUnit { get; set; } = "Fahrenheit";
        public Temp InputTemp { get; set; }
        public Temp OutputTemp { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
        }

        public void InputChanged()
        {
            OutputDegrees = 0.0;

            switch (InputUnit)
            {
                case "Fahrenheit":
                    InputTemp = new Fahrenheit(InputDegrees);
                    break;
                case "Celsius":
                    InputTemp = new Celsius(InputDegrees);
                    break;
                case "Kelvins":
                    InputTemp = new Kelvins(InputDegrees);
                    break;
                default:
                    break;
            }

            switch (OutputUnit)
            {
                case "Fahrenheit":
                    OutputTemp = new Fahrenheit(InputDegrees);
                    break;
                case "Celsius":
                    OutputTemp = new Celsius(InputDegrees);
                    break;
                case "Kelvins":
                    OutputTemp = new Kelvins(InputDegrees);
                    break;
                default:
                    break;
            }

            OutputDegrees = InputTemp.ConvertToTemperature(OutputTemp);

            this.StateHasChanged();
        }

        public async Task InputUnitSelected(string unit)
        {
            InputUnit = unit;
        }

        public async Task OutputUnitSelected(string unit)
        {
            OutputUnit = unit;
        }
    }
}
