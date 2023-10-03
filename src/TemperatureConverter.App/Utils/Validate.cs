namespace TemperatureConverter.App.Utils
{
    public class Validate
    {
        public static void ValidateCelsiusTemperature(double celsius)
        {
            if (celsius < -273.15)
            {
                throw new ArgumentException("Celsius value cannot be lower than -273.15°C (absolute zero).");
            }
        }

        public static void ValidateKelvinTemperature(double kelvin)
        {
            if (kelvin < 0)
            {
                throw new ArgumentException("Kelvin value cannot be zero or negative.");
            }
        }

        public static void ValidateNullTemperature(double? value)
        {
            if (value == null)
            {
                throw new ArgumentException("Temperature value cannot be null.");
            }
        }
    }
}
