public class Program
{
    public static void Main()
    {
        TempreratureConvertor();
    }

    public static void TempreratureConvertor()
    {
        Console.WriteLine("Welcome to the Temperature Converter!\nEnter your temperature:");
        float userTemperature = UserIntput();
        Console.WriteLine("What conversion you want to do?\n1: Celsius a Fahrenheit\n2: Fahrenheit a Celsius\n3: Celsius a Kelvin");
        int conversionType = (int)UserIntput(1, 3);

        switch (conversionType)
        {
            case 1:
                float fahrenheit = CelsiusToFahrenheit(userTemperature);
                Console.WriteLine($"{userTemperature}°C is equal to {fahrenheit}°F");
                break;
            case 2:
                float celsius = FahrenheitToCelsius(userTemperature);
                Console.WriteLine($"{userTemperature}°F is equal to {celsius}°C");
                break;
            case 3:
                float kelvin = CelsiusToKelvin(userTemperature);
                Console.WriteLine($"{userTemperature}°C is equal to {kelvin}K");
                break;
        }
    }

    public static float CelsiusToKelvin(float celsius)
    {
        return celsius + 273.15f;
    }

    public static float FahrenheitToCelsius(float fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static float CelsiusToFahrenheit(float celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static float UserIntput()
    {
        float userNumber;
        bool isValidInput = true;

        do
        {
            Console.WriteLine(isValidInput ? $"Please enter a number" : "Invalid input. Please enter a valid number.");
            isValidInput = float.TryParse(Console.ReadLine(), out userNumber);
        } while (!isValidInput);

        return userNumber;
    }

    public static float UserIntput(int min, int max)
    {
        float userNumber;
        bool isValidInput = true;
        bool isInRange = true;

        do
        {
            Console.WriteLine((isValidInput && isInRange) ? $"Please enter a number" : "Invalid input. Please enter a valid number.");
            isValidInput = float.TryParse(Console.ReadLine(), out userNumber);
            isInRange = userNumber >= min && userNumber <= max;
        } while (!(isValidInput && isInRange));

        return userNumber;
    }
}