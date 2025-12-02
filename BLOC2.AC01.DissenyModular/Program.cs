public class Program
{
    public static void Main()
    {
        string testDate = "27/11/2006";
        Console.WriteLine(testDate);
        Console.WriteLine(GetDayDate(testDate));
        Console.WriteLine(GetMonthDate(testDate));
        Console.WriteLine(GetYearDate(testDate));

    }

    public static string UserDateIntput()
    {

        string userDate;

        do
        {

            userDate = Console.ReadLine() ?? "";
        } while (!IsValidDate(userDate));

        return userDate;
    }

    public static bool IsValidDate(string date)
    {
        //DD/MM/YYYY
        //013456789 10
        /*
         0145789 10 are numbers
         36 are "/"
         
         */
        if (date.Length != 10)
        {
            return false;
        }

        if (!(date[3] != '/') || !(date[6] != '/'))
        {
            return false;
        }

        string dateNums = "";
        foreach (char c in date)
        {
            if (c != '/')
            {
                dateNums += c;
            }
        }

        


        return true;
    }

    public static int GetDayDate(string date)
    {
        return int.Parse(date.Substring(0, 2));
    }

    public static int GetMonthDate(string date)
    {
        return int.Parse(date.Substring(3, 2));
    }

    public static int GetYearDate(string date)
    {
        return int.Parse(date.Substring(6, 4));
    }
}


/*
 
 using System;

class Program
{
    static void Main()
    {
        string fecha = "27/11/2006";
        string fechaSinSlashes = ExtraerFechaSinSlashes(fecha);
        
        if (fechaSinSlashes.Length == 8 && EsNumerica(fechaSinSlashes))
        {
            Console.WriteLine("La fecha es válida.");
        }
        else
        {
            Console.WriteLine("La fecha no es válida.");
        }
    }

    // Función para extraer la fecha sin los caracteres '/'
    static string ExtraerFechaSinSlashes(string fecha)
    {
        string resultado = "";
        
        foreach (char c in fecha)
        {
            if (c != '/')
            {
                resultado += c;
            }
        }

        return resultado;
    }

    // Función para verificar si el string contiene solo números
    static bool EsNumerica(string cadena)
    {
        foreach (char c in cadena)
        {
            if (!Char.IsDigit(c)) // Verifica si el carácter no es un dígito
            {
                return false;
            }
        }
        return true;
    }
}

 */