namespace SwapExample;

public static class Utility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }   
}

internal class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 99;
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine("\nUsing swap");
        
        Utility.Swap(ref a, ref b);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}
