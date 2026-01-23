namespace WorkWithFile;

public class Contact
{
    public string Name { get; set; }
    public string number { get; set; }

    public Contact(string name, string number)
    {
        Name = name;
        this.number = number;
    }
}
