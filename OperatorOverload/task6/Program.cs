namespace Product;

internal class Program
{
    static void Main(string[] args)
    {
        var p1 = new Product("apple", 100, 22.0);
        var p2 = new Product("banana", 45, 30.0);

        Console.Write("p1 + 34: ");
        var p3 = p1 + 34;
        Console.WriteLine(p3.Count);

        Console.Write("p2 - 14: ");
        var p4 = p2 - 14;
        Console.WriteLine(p4.Count);

        Console.Write("p1 == p2: ");
        Console.WriteLine(p1 == p2);

        Console.Write("p1 != p2: ");
        Console.WriteLine(p1 != p2);

        Console.Write("p1 > p2: ");
        Console.WriteLine(p1 > p2);

        Console.Write("s1 < s2: ");
        Console.WriteLine(p1 < p2);
    }
}
