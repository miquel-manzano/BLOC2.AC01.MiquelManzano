public class Program
{
    public static void Main()
    {
        //int userNumber = 60;
        int userNumber = UserIntput();

        
    }

    public static void NumberFactorization(int num)
    {
        
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

    public static bool IsPrime(int num) //  la verdad es que lo saque de internet, pero entiendo como funciona
    {
        bool isPrime;
        if (num <= 1)
            isPrime = false;

        if (num == 2)
            isPrime = true;

        if (num % 2 == 0)
            isPrime = false;

        
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                isPrime = false;
        }

        isPrime = true;
        return isPrime;
    }
}