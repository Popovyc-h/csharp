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
        while(true)
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

        Console.Write("Enter url: ");
        while (true)
        {
            try
            {
                Url = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter url again: ");
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter description again: ");
            }
        }

        Console.Write("Enter ip address: ");
        while (true)
        {
            try
            {
                IpAddress = Console.ReadLine();
                break;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter ip address again: ");
            }
        }
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
                throw new Exception("Name cannot be empty!");
            
            name = value;
        }
    }

    public string Url
    {
        get => url;
        set
        {
            if(value.Length == 0)
                throw new Exception("Url cannot be empty!");
            
            url = value;
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

    public string IpAddress
    {
        get => ipAddress;
        set
        {
            if (value.Length == 0)
                throw new Exception("Ip address cannot be empty!");
            
            ipAddress = value;
        }
    }
}
