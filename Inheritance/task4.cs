namespace Worker;

public abstract class Worker
{
    public abstract void Print();
}

public class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("Chief executive officer, responsible for the entire company");
    }
}

public class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Security, responsible for security");
    }
}

public class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Manages the department, plans tasks");
    }
}

public class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Technical specialist, creates and maintains systems");
    }
}

internal class task4
{
    static void Main(string[] args)
    {
        var president = new President();
        var security = new Security();
        var manager = new Manager();
        var engineer = new Engineer();

        president.Print();
        Console.WriteLine();

        security.Print();
        Console.WriteLine();

        manager.Print();
        Console.WriteLine();

        engineer.Print();
    }
}
