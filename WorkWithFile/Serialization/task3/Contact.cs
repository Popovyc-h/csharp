public class Contact
{
    public string name { get; set; }
    public string number { get; set; }

    public Contact(string name, string number)
    {
        this.name = name;
        this.number = number;
    }

    public Contact() {}
}
