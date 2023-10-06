using FluentAssertions;
using TemperatureConverter.App.Utils;

namespace TemperatureConverter.Tests.Utils
{
    public class ValidateTests
    {
        [Theory(DisplayName = "ValidateCelsiusTemperature - Return Celsius when validated")]
        [InlineData(0)]
        [InlineData(100)]
        [InlineData(1000)]
        public void Validate_ValidateCelsiusTemperature_DoesNotThrowExceptionWhenCelsiusValueIsValid(double celsius)
        {
            Action action = () => Validate.ValidateCelsiusTemperature(celsius);

            action.Should().NotThrow<ArgumentException>();
        }

        [Theory(DisplayName = "ValidateCelsiusTemperature - Not return Celsius when not validated")]
        [InlineData(-273.16)]
        [InlineData(-1000)]
        public void Validate_ValidateCelsiusTemperature_ThrowsArgumentExceptionWhenCelsiusValueIsLowerThanAbsoluteZero(double celsius)
        {
            Action action = () => Validate.ValidateCelsiusTemperature(celsius);

            action.Should().Throw<ArgumentException>();
        }

        [Theory(DisplayName = "ValidateKelvinTemperature - Return Kelvin when validated")]
        [InlineData(0)]
        [InlineData(100)]
        [InlineData(1000)]
        public void Validate_ValidateKelvinTemperature_DoesNotThrowExceptionWhenKelvinValueIsValid(double kelvin)
        {
            Action action = () => Validate.ValidateKelvinTemperature(kelvin);

            action.Should().NotThrow<ArgumentException>();
        }

        [Theory(DisplayName = "ValidateKelvinTemperature - Not return Kelvin when not validated")]
        [InlineData(-1)]
        [InlineData(-1000)]
        public void Validate_ValidateKelvinTemperature_ThrowsArgumentExceptionWhenKelvinValueIsZeroOrNegative(double kelvin)
        {
            Action action = () => Validate.ValidateKelvinTemperature(kelvin);

            action.Should().Throw<ArgumentException>();
        }

        [Fact(DisplayName = "ValidateNullTemperature - Return null temperature value")]
        public void Validate_ValidateNullTemperature_ThrowsArgumentExceptionWhenTemperatureValueIsNull()
        {

            double? value = null;

            Action action = () => Validate.ValidateNullTemperature(value);

            action.Should().Throw<ArgumentException>();
        }

        [Fact(DisplayName = "ValidateNullTemperature - Not return null temperature value")]
        public void Validate_ValidateNullTemperature_DoesNotThrowExceptionWhenTemperatureValueIsNotNull()
        {
            double? value = 100;

            Action action = () => Validate.ValidateNullTemperature(value);

            action.Should().NotThrow<ArgumentException>();
        }
    }
}
