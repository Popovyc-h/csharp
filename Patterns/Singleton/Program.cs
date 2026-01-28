namespace Singleton;

internal class Program
{
    static void Main(string[] args)
    {
        var gov1 = Government.GetInstance();
        var gov2 = Government.GetInstance();

        Console.WriteLine(gov1 == gov2);
    }
}
