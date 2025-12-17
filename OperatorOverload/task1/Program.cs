namespace MagazineTask;

internal class Program
{
    static void Main(string[] args)
    {
        var m1 = new Magazine();
        var m2 = new Magazine();

        m1.Input();
        Console.WriteLine();
        m2.Input();

        m1.ShowData();
        m2.ShowData();

        Console.Write("\nm1 + 3 employees = ");
        Magazine m3 = m1 + 3;
        Console.WriteLine(m3.NumberOfEmployees);

        Console.Write("m1 - 4 employees = ");
        Magazine m4 = m1 - 4;
        Console.WriteLine(m4.NumberOfEmployees);

        Console.Write("m1 == m2: ");
        Console.WriteLine(m1 == m2);

        Console.Write("m1 != m2: ");
        Console.WriteLine(m1 != m2);

        Console.Write("m1 > m2: ");
        Console.WriteLine(m1 > m2);

        Console.Write("m1 < m2: ");
        Console.WriteLine(m1 < m2);

        Console.Write("m1.Equals(m2): ");
        Console.WriteLine(m1.Equals(m2));
    }
}
