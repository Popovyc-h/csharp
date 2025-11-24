Magazine magazine = new Magazine();

magazine.input();
magazine.showData();

class Magazine
{
    private string name;
    private int year;
    private string description;
    private string contactPhone;
    private string contactEmail;

    public void input()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();
        
        Console.Write("Enter year: ");
        Year = int.Parse(Console.ReadLine());
        
        Console.Write("Enter description: ");
        Description = Console.ReadLine();
        
        Console.Write("Enter phone: ");
        ContactPhone = Console.ReadLine();
        
        Console.Write("Enter email: ");
        ContactEmail = Console.ReadLine();
    }

    public void showData()
    {
        Console.WriteLine("\n=== Magazine ===");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Phone: {contactPhone}");
        Console.WriteLine($"Email: {contactEmail}\n");
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

    public int Year
    {
        get => year;
        set
        {
            if (value < 1800 || value > 2025)
            {
                Console.WriteLine("Error: Year must be between 1800 and 2025!");
                return;
            }
            year = value;
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
