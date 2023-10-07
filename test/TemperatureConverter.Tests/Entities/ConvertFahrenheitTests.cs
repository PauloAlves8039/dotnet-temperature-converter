using TemperatureConverter.App.Entities;

namespace TemperatureConverter.Tests.Entities
{
    public class ConvertFahrenheitTests
    {
        [Theory(DisplayName = "ConvertFahrenheitToCelsius - Return Fahrenheit to Celsius")]
        [InlineData(-459.67, -273.15)]
        [InlineData(-40, -40)]
        [InlineData(32, 0)]
        [InlineData(98.6, 37)]
        [InlineData(212, 100)]
        public void ConvertFahrenheit_ConvertFahrenheitToCelsius_ShouldReturnCelsiusWhenCorrectValue(double fahrenheit, double celsiusExpected)
        {
            var convertFahrenheit = new ConvertFahrenheit(fahrenheit);

            var celsius = convertFahrenheit.ConvertFahrenheitToCelsius();

            Assert.Equal(celsiusExpected, celsius);
        }

        [Theory(DisplayName = "ConvertFahrenheitToCelsius - Not return Fahrenheit to Celsius")]
        [InlineData(-500, -1000)]
        [InlineData(20, 100)]
        [InlineData(50, 200)]
        [InlineData(98.6, 37.1)]
        [InlineData(212, 99.99)]
        public void ConvertFahrenheit_ConvertFahrenheitToCelsius_ShouldReturnCelsiusWhenNotCorrectValue(double fahrenheit, double celsiusNotExpected)
        {
            var convertFahrenheit = new ConvertFahrenheit(fahrenheit);

            var celsius = convertFahrenheit.ConvertFahrenheitToCelsius();

            Assert.NotEqual(celsiusNotExpected, celsius);
        }

        [Theory(DisplayName = "ConvertFahrenheitToKelvin - Return Fahrenheit to Kelvin")]
        [InlineData(-459.67, 0)]
        [InlineData(-40, 233.15)]
        [InlineData(32, 273.15)]
        [InlineData(98.6, 310.15)]
        [InlineData(212, 373.15)]
        public void ConvertFahrenheit_ConvertFahrenheitToKelvin_ShouldReturnCelsiusWhenCorrectValue(double fahrenheit, double kelvinExpected)
        {
            var convertFahrenheit = new ConvertFahrenheit(fahrenheit);

            var kelvin = convertFahrenheit.ConvertFahrenheitToKelvin();

            Assert.Equal(kelvinExpected, Math.Round(kelvin, 2));
        }

        [Theory(DisplayName = "ConvertFahrenheitToKelvin - Not return Fahrenheit to Kelvin")]
        [InlineData(-20, 253.15)]
        [InlineData(0, 273.15)]
        [InlineData(100, 373.15)]
        [InlineData(1000, 1273.15)]
        public void ConvertFahrenheit_ConvertFahrenheitToKelvin_ShouldReturnCelsiusWhenNotCorrectValue(double fahrenheit, double kelvinNotExpected)
        {
            var convertFahrenheit = new ConvertFahrenheit(fahrenheit);

            var kelvin = convertFahrenheit.ConvertFahrenheitToKelvin();

            Assert.NotEqual(kelvinNotExpected, kelvin);
        }
    }
}
