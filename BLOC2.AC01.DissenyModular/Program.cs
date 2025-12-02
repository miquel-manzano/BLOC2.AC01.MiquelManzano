using System.Net;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        const string AskUserIdMsg = "Enter a DNI or NIE to validate: ";
        const string ValidDNIMsg = "The DNI is valid.";
        const string InvalidDNIMsg = "The DNI is invalid.";
        const string ValidNIEMsg = "The NIE is valid.";
        const string InvalidNIEMsg = "The NIE is invalid.";
        const string InvalidIDMsg = "Invalid ID";

        //string testDNI = "12345678Z";
        //string testNIE = "X1234567L";
        Console.WriteLine(AskUserIdMsg);
        string userID = Console.ReadLine() ?? "";

        if (IsIDLengthValid(userID))// Compruebo aqui el tamaño porque si no pone nada no hay nada que validar
        {
            if (IsDNI(userID))
            {
                Console.WriteLine(IsValidDNI(userID) ? ValidDNIMsg : InvalidDNIMsg);
            }
            else
            {
                Console.WriteLine(IsValidNIE(userID) ? ValidNIEMsg : InvalidNIEMsg);
            }
        }
        else
        {
            Console.WriteLine(InvalidIDMsg);
        }
    }

    public static bool IsDNI(string id)
    {
        return char.IsNumber(id[0]);
    }

    public static bool IsValidDNI(string dni)
    {
        string numberPart = dni.Substring(0, 8);
        char letterPart = dni[8];

        if (!IsStringNumeric(numberPart))
        {
            return false;
        }

        if (!IsCharLetter(letterPart))
        {
            return false;
        }

        int number = int.Parse(numberPart);
        string validLetters = "TRWAGMYFPDXBNJZSQVHLCKE";
        char expectedLetter = validLetters[number % 23];
        if (char.ToUpper(letterPart) != expectedLetter)
        {
            return false;
        }

        return true;
    }

    public static bool IsValidNIE(string nie)
    {
        string numberPart = nie.Substring(1, 7);
        char firstLetter = nie[0];
        char lastLetter = nie[8];

        if (!IsStringNumeric(numberPart))
        {
            return false;
        }

        if (!IsCharLetter(firstLetter) || !IsCharLetter(lastLetter))
        {
            return false;
        }

        if (!"XYZ".Contains(firstLetter))
        {
            return false;
        }

        return true;
    }

    public static bool IsIDLengthValid(string id)
    {
        return id.Length == 9;
    }

    public static bool IsStringNumeric(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsDigit(str[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsCharLetter(char c)
    {
        return char.IsLetter(c);
    }
}