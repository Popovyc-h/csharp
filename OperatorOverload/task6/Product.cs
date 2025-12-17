namespace Product;

internal class Product
{
    private string name;
    private int count;
    private double price;

    public Product(string name, int count, double price)
    {
        Name = name;
        Count = count;
        Price = price;
    }
    public Product()
    {
        Name = "Unknow";
        Count = 0;
        Price = 0;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty", nameof(name));
            
            name = value;
        }
    }

    public int Count
    {
        get => count;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The value cannot be negative", nameof(count));
            
            count = value;
        }
    }

    public double Price
    {
        get => price;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The price cannot be negative", nameof(price));

            price = value;
        }
    }

    public static Product operator + (Product p, int value)
    {
        var result = new Product();

        result.Name = p.Name;
        result.Count = p.Count + value;
        result.Price = p.Price;

        return result;
    }

    public static Product operator - (Product p, int value)
    {
        var result = new Product();

        result.Name = p.Name;
        result.Count = p.Count - value;
        result.Price = p.Price;

        return result;
    }

    public static bool operator == (Product a, Product b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return a.Price == b.Price;
    }

    public static bool operator != (Product a, Product b) => !(a == b);

    public override bool Equals(object obj)
    {
        if (obj is not Product other)
            return false;

        return Price == other.Price;
    }

    public static bool operator > (Product a, Product b)
    {
        if (a is null || b is null)
            throw new ArgumentNullException();

        return a.Count > b.Count;
    }

    public static bool operator < (Product a, Product b)
    {
        if (a is null || b is null)
            throw new ArgumentNullException();

        return a.Count < b.Count;
    }
}
