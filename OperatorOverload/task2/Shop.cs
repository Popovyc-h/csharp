namespace ShopTask;

internal class Shop
{
    private string name;
    private string address;
    private string description;
    private string contactPhone;
    private string contactEmail;
    private double area;

    public void Input()
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

        Console.Write("Enter area: ");
        while (true)
        {
            try
            {
                Area = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter area again: ");
            }
        }
    }

    public void showData()
    {
        Console.WriteLine("\n=== Shop ===");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Phone: {ContactPhone}");
        Console.WriteLine($"Email: {ContactEmail}");
        Console.WriteLine($"Area: {Area}");
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

    public double Area
    {
        get => area;
        set
        {
            if (value < 0)
                throw new Exception("Area cannot be negative");

            area = value;
        }
    }

    public static Shop operator +(Shop s, double value)
    {
        var result = new Shop();

        result.Name = s.Name;
        result.Address = s.Address;
        result.Description = s.Description;
        result.ContactPhone = s.ContactPhone;
        result.ContactEmail = s.ContactEmail;
        result.Area = s.Area + value;

        return result;
    }

    public static Shop operator -(Shop s, double value)
    {
        var result = new Shop();

        result.Name = s.Name;
        result.Address = s.Address;
        result.Description = s.Description;
        result.ContactPhone = s.ContactPhone;
        result.ContactEmail = s.ContactEmail;
        result.Area = s.Area - value;

        return result;
    }

    public static bool operator ==(Shop a, Shop b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return a.Area == b.Area;
    }

    public static bool operator !=(Shop a, Shop b) => !(a == b);

    public override bool Equals(object obj)
    {
        if (obj is not Shop other)
            return false;

        return Area == other.Area;
    }

    public static bool operator >(Shop a, Shop b)
    {
        if (a is null || b is null)
            throw new ArgumentNullException();

        return a.Area > b.Area;
    }

    public static bool operator <(Shop a, Shop b)
    {
        if (a is null || b is null)
            throw new ArgumentNullException();

        return a.Area < b.Area;
    }
}
