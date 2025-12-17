namespace ShopTask;

internal class Program
{
    static void Main(string[] args)
    {
        var s1 = new Shop();
        var s2 = new Shop();

        s1.Input();
        Console.WriteLine();
        s2.Input();

        s1.showData();
        s2.showData();

        Console.Write("\ns1 + 10.5 area = ");
        var s3 = s1 + 10.5;
        Console.WriteLine(s3.Area);

        Console.Write("s1 - 5.5 area = ");
        var s4 = s1 - 5.5;
        Console.WriteLine(s4.Area);

        Console.Write("s1 == s2: ");
        Console.WriteLine(s1 == s2);

        Console.Write("s1 != s2: ");
        Console.WriteLine(s1 != s2);

        Console.Write("s1 > s2: ");
        Console.WriteLine(s1 > s2);

        Console.Write("s1 < s2: ");
        Console.WriteLine(s1 < s2);

        Console.Write("s1.Equals(s2): ");
        Console.WriteLine(s1.Equals(s2));
    }
}
