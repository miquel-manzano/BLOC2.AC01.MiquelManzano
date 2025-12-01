using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        //int userNumber = 52814
        int userNumber = UserIntput();
        Console.WriteLine($"Numero introduit: {userNumber}");
        Console.WriteLine($"Suma de les xifres que ocupen posicions parells: {EvenAddition(userNumber)}");
        Console.WriteLine($"Suma de xifres senars: {NumberProduct(userNumber)}");
        Console.WriteLine($"La xifra mes gran dins del numero es: {BiggestNumber(userNumber)}");
        Console.WriteLine($"La xifra mes petita dins del numero es: {SmallestNumber(userNumber)}");
    }

    // se puede refactorizar para evitar repetir codigo
    public static  void MinMaxNums(int num, out int minNum, out int maxNum)//hehe
    {

        maxNum = 0;
        minNum = num;
        int digit;
        string numberString = num.ToString();
        for (int i = 0; i < numberString.Length; i++)
        {
            digit = int.Parse(numberString[i].ToString());
            if (maxNum <= digit)
            {
                maxNum = digit;
            }
            if (minNum >= digit)
            {
                minNum = digit;
            }
        }
    }


    public static int EvenAddition(int number)
    {
        int sum = 0;
        int digit;
        string numberString = number.ToString();
        for (int i = 2; i <= numberString.Length; i += 2)
        {
            digit = int.Parse(numberString[i-1].ToString());
            sum += digit;
        }
        return sum;
    }

    public static int NumberProduct(int number)
    {
        int sum = 1;
        int digit;
        string numberString = number.ToString();
        for (int i = 0; i < numberString.Length; i += 2)
        {
            digit = int.Parse(numberString[i].ToString());
            sum = sum * digit;
        }
        return sum;
    }

    public static int BiggestNumber(int number)
    {
        int biggestNum = 0;
        int digit;
        string numberString = number.ToString();
        for (int i = 0; i < numberString.Length; i ++)
        {
            digit = int.Parse(numberString[i].ToString());
            if (biggestNum <= digit)
            {
                biggestNum = digit;
            }
        }
        return biggestNum;
    }

    public static int SmallestNumber(int number)
    {
        int smallestNum = number;
        int digit;
        string numberString = number.ToString();
        for (int i = 0; i < numberString.Length; i++)
        {
            digit = int.Parse(numberString[i].ToString());
            if (smallestNum >= digit)
            {
                smallestNum = digit;
            }
        }
        return smallestNum;
    }


    public static int UserIntput()
    {
        int userNumber;
        bool isValidInput = true;

        do
        {
            Console.WriteLine(isValidInput ? $"Please enter a number" : "Invalid input. Please enter a valid number.");
            isValidInput = int.TryParse(Console.ReadLine(), out userNumber);
        } while (!isValidInput);

        return userNumber;
    }
}