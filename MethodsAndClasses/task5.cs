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
        while (true)
        {
            try
            {
                Name = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter name again: ");
            }
        }


        Console.Write("Enter year: ");
        while(true)
        {
            try
            {
                Year = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter year again: ");
            }
        }

        Console.Write("Enter description: ");
        while (true)
        {
            try
            {
                Description = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter description again: ");
            }
        }

        Console.Write("Enter phone: ");
        while (true)
        {
            try
            {
                ContactPhone = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter phone again: ");
            }
        }

        Console.Write("Enter email: ");
        while (true)
        {
            try
            {
                ContactEmail = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter email again: ");
            }
        }
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
                throw new Exception("Name cannot be empty!");

            name = value;
        }
    }

    public int Year
    {
        get => year;
        set
        {
            if (value < 1800 || value > 2025)
                throw new Exception("Year must be between 1800 and 2025!");
            
            year = value;
        }
    }

    public string Description
    {
        get => description;
        set
        {
            if (value.Length == 0)
                throw new Exception("Description cannot be empty!");

            description = value;
        }
    }

    public string ContactPhone
    {
        get => contactPhone;
        set
        {
            if (value.Length == 0)
                throw new Exception("Phone cannot be empty!");
            
            contactPhone = value;
        }
    }

    public string ContactEmail
    {
        get => contactEmail;
        set
        {
            if (value.Length == 0)
                throw new Exception("Email cannot be empty!");
            
            contactEmail = value;
        }
    }
}
