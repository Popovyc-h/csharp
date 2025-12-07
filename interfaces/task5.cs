namespace xxx;

public interface IDrivable
{
    public void StartEngine();
    public void StopEngine();
    public void Drive();
}

public class Car : IDrivable
{
    public void StartEngine()
    {
        Console.WriteLine("Starting the car engine");
    }

    public void StopEngine()
    {
        Console.WriteLine("Stopping the car engine");
    }

    public void Drive()
    {
        Console.WriteLine("The car drove off");
    }
}

public class Motorcycle : IDrivable
{
    public void StartEngine()
    {
        Console.WriteLine("Starting the motorcycle engine");
    }

    public void StopEngine()
    {
        Console.WriteLine("Stopping the motorcycle engine");
    }

    public void Drive()
    {
        Console.WriteLine("The motorcycle drove off");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var car = new Car();
        var motorcycle = new Motorcycle();

        car.StartEngine();
        car.Drive();
        car.StopEngine();

        Console.WriteLine();
        
        motorcycle.StartEngine();
        motorcycle.Drive();
        motorcycle.StopEngine();
    }
}
