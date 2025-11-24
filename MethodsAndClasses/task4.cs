Website website = new Website();

website.input();
website.showData();

class Website
{
    private string name;
    private string url;
    private string description;
    private string ipAddress;

    public void input()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();

        Console.Write("Enter url: ");
        Url = Console.ReadLine();

        Console.Write("Enter description: ");
        Description = Console.ReadLine();

        Console.Write("Enter ip address: ");
        IpAddress = Console.ReadLine();
    }

    public void showData()
    {
        Console.WriteLine("\n=== Website ===");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Url: {url}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Ip address: {ipAddress}");
    }
    public string Name
    {
        get => name;
        set
        {
            if (value.Length == 0)
            {
                Console.WriteLine("Error: Name cannot be empty!");
                return;
            }
            name = value;
        }
    }

    public string Url
    {
        get => url;
        set
        {
            if(value.Length == 0)
            {
                Console.WriteLine("Error: Url cannot be empty!");
                return;
            }
            url = value;
        }
    }

    public string Description
    {
        get => description;
        set
        {
            if (value.Length == 0)
            {
                Console.WriteLine("Error: Description cannot be empty!");
                return;
            }
            description = value;
        }
    }

    public string IpAddress
    {
        get => ipAddress;
        set
        {
            if (value.Length == 0)
            {
                Console.WriteLine("Error: Ip address cannot be empty!");
                return;
            }
            ipAddress = value;
        }
    }
}
