namespace Fraction;

internal class Program
{
    static void Main(string[] args)
    {
        var a = new Fraction(1, 2).Reduce();
        var b = new Fraction(2, 4).Reduce();

        Console.WriteLine(a);
        Console.WriteLine(b);

        var sum = a + b;
        Console.WriteLine($"Sum = {sum}");

        var diff = a - b;
        Console.WriteLine($"Diff = {diff}");

        var mul = a * b;
        Console.WriteLine($"Mul = {mul}");

        var div = a / b;
        Console.WriteLine($"Div = {div}");

        Console.WriteLine($"a == b: {a == b}");

        Console.WriteLine($"a != b: {a != b}");
    }
}
