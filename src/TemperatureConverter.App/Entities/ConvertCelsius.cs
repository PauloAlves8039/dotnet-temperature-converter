using TemperatureConverter.App.Interfaces;
using TemperatureConverter.App.Utils;

namespace TemperatureConverter.App.Entities
{
    public class ConvertCelsius : IConvertCelsius
    {
        public double Celsius { get; }

        public ConvertCelsius(double celsius)
        {
            Validate.ValidateCelsiusTemperature(celsius);
            Validate.ValidateNullTemperature(celsius);
            Celsius = celsius;
        }

        public double ConvertCelsiusToFahrenheit()
        {
            var fahrenheit = (Celsius * 9 / 5) + 32;
            return Math.Round(fahrenheit, 2);
        }

        public double ConvertCelsiusToKelvin()
        {
            var kelvin = Celsius + 273.15;
            return Math.Round(kelvin, 2);
        }
    }
}
