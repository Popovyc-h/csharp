Shop shop = new Shop();

shop.input();
shop.showData();

class Shop
{
    private string name;
    private string address;
    private string description;
    private string contactPhone;
    private string contactEmail;
    
    public void input()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();

        Console.Write("Enter address: ");
        Address = Console.ReadLine();

        Console.Write("Enter description: ");
        Description = Console.ReadLine();

        Console.Write("Enter phone: ");
        ContactPhone = Console.ReadLine();

        Console.Write("Enter email: ");
        ContactEmail = Console.ReadLine();
    }

    public void showData()
    {
        Console.WriteLine("\n=== Shop ===");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Phone: {contactPhone}");
        Console.WriteLine($"Email: {ContactEmail}");
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

    public string Address
    {
        get => address;
        set
        {
            if (value.Length == 0)
            {
                Console.WriteLine("Error: Addres cannot be empty!");
                return;
            }
            address = value;
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

    public string ContactPhone
    {
        get => contactPhone;
        set
        {
            if (value.Length == 0)
            {
                Console.WriteLine("Error: Phone cannot be empty!");
                return;
            }
            contactPhone = value;
        }
    }

    public string ContactEmail
    {
        get => contactEmail;
        set
        {
            if (value.Length == 0)
            {
                Console.WriteLine("Error: Email cannot be empty!");
                return;
            }
            contactEmail = value;
        }
    }
}
