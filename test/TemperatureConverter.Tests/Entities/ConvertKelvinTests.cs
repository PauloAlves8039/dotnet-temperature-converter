using TemperatureConverter.App.Entities;

namespace TemperatureConverter.Tests.Entities
{
    public class ConvertKelvinTests
    {
        [Theory(DisplayName = "ConvertKelvinToCelsius - Return Kelvin to Celsius")]
        [InlineData(100.00, -173.15)]
        [InlineData(300.00, 26.85)]
        [InlineData(500.00, 226.85)]
        [InlineData(1000.00, 726.85)]
        [InlineData(0.00, -273.15)]
        public void ConvertKelvin_ConvertKelvinToCelsius_ShouldReturnCelsiusWhenCorrectValue(double kelvin, double celsiusExpected)
        {
            var convertKelvin = new ConvertKelvin(kelvin);

            var _kelvin = convertKelvin.ConvertKelvinToCelsius();

            Assert.Equal(celsiusExpected, _kelvin);
        }

        [Theory(DisplayName = "ConvertKelvinToCelsius - Not return Kelvin to Celsius")]
        [InlineData(100.00, -173.00)]
        [InlineData(300.00, 26.55)]
        [InlineData(500.00, 226.45)]
        [InlineData(1000.00, 726.15)]
        [InlineData(0.00, -273.25)]
        public void ConvertKelvin_ConvertKelvinToCelsius_ShouldReturnCelsiusWhenNotCorrectValue(double kelvin, double celsiusNotExpected)
        {
            var convertKelvin = new ConvertKelvin(kelvin);

            var _kelvin = convertKelvin.ConvertKelvinToCelsius();

            Assert.NotEqual(celsiusNotExpected, _kelvin);
        }

        [Theory(DisplayName = "ConvertKelvinToFahrenheit - Return Kelvin to Fahrenheit")]
        [InlineData(300.00, 80.33)]
        [InlineData(500.00, 440.33)]
        [InlineData(1000.00, 1340.33)]
        [InlineData(2000.00, 3140.33)]
        [InlineData(0.00, -459.67)]
        public void ConvertKelvin_ConvertKelvinToFahrenheit_ShouldReturnFahrenheitWhenCorrectValue(double kelvin, double fahrenheitExpected)
        {
            var convertKelvin = new ConvertKelvin(kelvin);

            var _kelvin = convertKelvin.ConvertKelvinToFahrenheit();

            Assert.Equal(fahrenheitExpected, _kelvin);
        }

        [Theory(DisplayName = "ConvertKelvinToFahrenheit - Not return Kelvin to Fahrenheit")]
        [InlineData(300.00, 90.83)]
        [InlineData(500.00, 450.93)]
        [InlineData(1000.00, 1440.31)]
        [InlineData(2000.00, 3940.32)]
        [InlineData(0.00, -455.68)]
        public void ConvertKelvin_ConvertKelvinToFahrenheit_ShouldReturnFahrenheitWhenNotCorrectValue(double kelvin, double fahrenheitNotExpected)
        {
            var convertKelvin = new ConvertKelvin(kelvin);

            var _kelvin = convertKelvin.ConvertKelvinToFahrenheit();

            Assert.NotEqual(fahrenheitNotExpected, _kelvin);
        }
    }
}
