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

        Console.Write("Enter address: ");
        while (true)
        {
            try
            {
                Address = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter address again: ");
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
                throw new Exception("Name cannot be empty!");

            name = value;
        }
    }

    public string Address
    {
        get => address;
        set
        {
            if (value.Length == 0)
                throw new Exception("Addres cannot be empty!");
            
            address = value;
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
