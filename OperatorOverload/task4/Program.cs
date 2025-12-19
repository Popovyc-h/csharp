namespace TemperatureArray;

internal class Program
{
    static void Main(string[] args)
    {
        var temps = new TemperatureArray();

        temps[0] = 10;
        temps[1] = 12;
        temps[2] = 14;
        temps[3] = 16;
        temps[4] = 18;
        temps[5] = 20;
        temps[6] = 22;

        Console.Write("Monday: ");
        Console.WriteLine(temps[0]);

        Console.Write("Sunday: ");
        Console.WriteLine(temps[6]);

        Console.Write("Temperature average: ");
        Console.WriteLine(temps.CalculateWeeklyAverageTemperature());

    }
}
