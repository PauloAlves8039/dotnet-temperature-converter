using TemperatureConverter.App.Interfaces;
using TemperatureConverter.App.Utils;

namespace TemperatureConverter.App.Entities
{
    public class ConvertKelvin : IConvertKelvin
    {
        public double Kelvin { get; }

        public ConvertKelvin(double kelvin)
        {
            Validate.ValidateKelvinTemperature(kelvin);
            Validate.ValidateNullTemperature(kelvin);
            Kelvin = kelvin;
        }

        public double ConvertKelvinToCelsius()
        {
            var celsius = Kelvin - 273.15;
            return Math.Round(celsius, 2);
        }

        public double ConvertKelvinToFahrenheit()
        {
            var fahrenheit = (Kelvin - 273.15) * 9 / 5 + 32;
            return Math.Round(fahrenheit, 2);
        }
    }
}
