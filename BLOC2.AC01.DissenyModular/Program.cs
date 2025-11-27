public class Program
{
    public static void Main()
    {
        int myNumber = 5, maxRange = 10, minRange = 4;
        Console.WriteLine($"The number: {myNumber} is between {minRange} and {maxRange}??");
        Console.WriteLine(isInRange(myNumber, minRange, maxRange) ? $"Yes, is between {minRange} and {maxRange}" : $"No, is not between {minRange} and {maxRange}");
    }

    public static bool isInRange(int number, int min, int max)
    {
        return number >= min && number <= max;
    }
}