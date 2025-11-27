public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Harcoded just for testing purposes
        Console.WriteLine("Parking costs:");
        Console.WriteLine($"Jhon 4 h 24 min: {ParkingCost(4, 24)}€\nAlex 20 h 30 min: {ParkingCost(20, 30)}€\nCarlos 40 min {ParkingCost(0, 40)}€");
    }

    public static decimal ParkingCost(float hours, float mins)
    {        
        float totalHores = hours + (mins / 60.0f);

        decimal cost = 0.0m;

        if (totalHores <= 1)
        {
            cost = 3.50m;
        }
        else if (totalHores <= 5)
        {
            cost = (decimal)totalHores * 2.00m;
        }
        else
        {
            cost = (decimal)totalHores * 1.50m;
        }
        return cost;
    }
}