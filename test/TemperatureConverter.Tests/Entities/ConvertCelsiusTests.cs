using TemperatureConverter.App.Entities;

namespace TemperatureConverter.Tests.Entities
{
    public class ConvertCelsiusTests
    {
        [Theory(DisplayName = "ConvertCelsiusToFahrenheit - Return Celsius to Fahrenheit")]
        [InlineData(-20, -4)]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        [InlineData(1000, 1832)]
        public void ConvertCelsius_ConvertCelsiusToFahrenheit_ShouldReturnFahrenheitWhenCorrectValue(double celsius, double fahrenheitExpected)
        {
            var convertCelsius = new ConvertCelsius(celsius);

            var fahrenheit = convertCelsius.ConvertCelsiusToFahrenheit();

            Assert.Equal(fahrenheitExpected, fahrenheit);
        }

        [Theory(DisplayName = "ConvertCelsiusToFahrenheit - Not return Celsius to Fahrenheit")]
        [InlineData(-20, -5)]
        [InlineData(0, 31)]
        [InlineData(100, 211)]
        [InlineData(1000, 1831)]
        public void ConvertCelsius_ConvertCelsiusToFahrenheit_ShouldReturnFahrenheitWhenNotCorrectValue(double celsius, double fahrenheitNotExpected)
        {
            var convertCelsius = new ConvertCelsius(celsius);

            var fahrenheit = convertCelsius.ConvertCelsiusToFahrenheit();

            Assert.NotEqual(fahrenheitNotExpected, fahrenheit);
        }

        [Theory(DisplayName = "ConvertCelsiusToKelvin - Return Celsius to Kelvin")]
        [InlineData(-20, 253.15)]
        [InlineData(0, 273.15)]
        [InlineData(100, 373.15)]
        [InlineData(1000, 1273.15)]
        public void ConvertCelsius_ConvertCelsiusToKelvin_ShouldReturnKelvinWhenCorrectValue(double celsius, double kelvinExpected)
        {
            var convertCelsius = new ConvertCelsius(celsius);

            var kelvin = convertCelsius.ConvertCelsiusToKelvin();

            Assert.Equal(kelvinExpected, kelvin);
        }

        [Theory(DisplayName = "ConvertCelsiusToKelvin - Not return Celsius to Kelvin")]
        [InlineData(-20, -5)]
        [InlineData(0, -4.15)]
        [InlineData(100, -273.15)]
        [InlineData(1000, 726.85)]
        public void ConvertCelsius_ConvertCelsiusToKelvin_ShouldReturnKelvinWhenNotCorrectValue(double celsius, double kelvinNotExpected)
        {
            var convertCelsius = new ConvertCelsius(celsius);

            var kelvin = convertCelsius.ConvertCelsiusToKelvin();

            Assert.NotEqual(kelvinNotExpected, kelvin);
        }
    }
}
