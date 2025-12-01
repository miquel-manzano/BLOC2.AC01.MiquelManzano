using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        //int userNumber = 60;
        int userNumber = UserIntput();
        NumberFactorization(userNumber);
    }

    public static void NumberFactorization(int num)
    {
        int factor;
        Console.WriteLine($"The prime factorization of {num} is:");
        for (factor = 2; factor <= num; factor++)
        {
            while (IsPrime(factor) && num % factor == 0)
            {
                Console.Write(factor + " ");
                num /= factor;
            }
        }
        Console.WriteLine();
    }

    public static int UserIntput()
    {
        int userNumber;
        bool isValidInput = true;
        bool isNatural = true;

        do
        {
            Console.WriteLine(isValidInput && isNatural ? $"Please enter a number" : "Invalid input. Please enter a valid number.");
            isValidInput = int.TryParse(Console.ReadLine(), out userNumber);
            isNatural = userNumber > 0;
        } while (!(isValidInput && isNatural));

        return userNumber;
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}