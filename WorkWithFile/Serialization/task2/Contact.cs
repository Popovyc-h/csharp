public class Contact
{
    public string Name { get; set; }
    public string number { get; set; }

    public Contact(string name, string number)
    {
        Name = name;
        this.number = number;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine();
    }
}
