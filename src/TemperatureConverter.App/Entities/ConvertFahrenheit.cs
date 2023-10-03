using TemperatureConverter.App.Utils;

namespace TemperatureConverter.App.Entities
{
    public class ConvertFahrenheit
    {
        public double Fahrenheit { get; }

        public ConvertFahrenheit(double fahrenheit)
        {
            Validate.ValidateNullTemperature(fahrenheit);
            Fahrenheit = fahrenheit;
        }

        public double ConvertFahrenheitToCelsius() 
        {
            var celsius = (Fahrenheit - 32) * 5 / 9;
            return Math.Round(celsius);
        }

        public double ConvertFahrenheitToKelvin() 
        {
            var kelvin = (Fahrenheit - 32) * 5 / 9 + 273.15;
            return kelvin;
        }
    }
}
