using System.Globalization;
using TemperatureConverter.App.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******************** TEMPERATURE CONVERTER ********************");

        var culture = CultureInfo.InvariantCulture;
        double inputValue;

        while (true)
        {
            Console.WriteLine("\n----------------------- CHOOSE AN OPTION -----------------------\n");
            Console.WriteLine("1. Celsius => Convert to Fahrenheit / Convert to Kelvin");
            Console.WriteLine("2. Fahrenheit => Convert to Celsius / Convert to Kelvin");
            Console.WriteLine("3. Kelvin => Convert to Celsius / Convert to Fahrenheit");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            var choice = int.Parse(Console.ReadLine());

            if (choice == 4)
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            Console.Write("\nEnter the temperature value: ");
            inputValue = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("\n---------------------------- RESULT ----------------------------\n");

            switch (choice)
            {
                case 1:
                    var convertCelsius = new ConvertCelsius(inputValue);
                    var celsiusToFahrenheitResult = convertCelsius.ConvertCelsiusToFahrenheit();
                    var celsiusToKelvinResult = convertCelsius.ConvertCelsiusToKelvin();
                    Console.WriteLine($"{inputValue.ToString("F2", culture)}° Celsius equals to {celsiusToFahrenheitResult.ToString("F2", culture)}° Fahrenheit.");
                    Console.WriteLine($"{inputValue.ToString("F2", culture)}° Celsius equals to {celsiusToKelvinResult.ToString("F2", culture)}° Kelvin.");
                    break;
                case 2:
                    var convertFahrenheit = new ConvertFahrenheit(inputValue);
                    var fahrenheitToCelsiusResult = convertFahrenheit.ConvertFahrenheitToCelsius();
                    var fahrenheitToKelvinResult = convertFahrenheit.ConvertFahrenheitToKelvin();
                    Console.WriteLine($"{inputValue.ToString("F2", culture)}° Fahrenheit equals to {fahrenheitToCelsiusResult.ToString("F2", culture)}° Celsius.");
                    Console.WriteLine($"{inputValue.ToString("F2", culture)}° Fahrenheit equals to {fahrenheitToKelvinResult.ToString("F2", culture)}° Kelvin.");
                    break;
                case 3:
                    var convertKelvin = new ConvertKelvin(inputValue);
                    var kelvinToCelsiusResult = convertKelvin.ConvertKelvinToCelsius();
                    var kelvinToFahrenheitResult = convertKelvin.ConvertKelvinToFahrenheit();
                    Console.WriteLine($"{inputValue.ToString("F2", culture)}° Kelvin equals to {kelvinToCelsiusResult.ToString("F2", culture)}° Celsius.");
                    Console.WriteLine($"{inputValue.ToString("F2", culture)}° Kelvin equals to {kelvinToFahrenheitResult.ToString("F2", culture)}° Fahrenheit.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
        }

        Console.ReadLine();
    }
}