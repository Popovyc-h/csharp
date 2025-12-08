namespace money;

public class Money
{
    private int whole;
    private int cent;

    public Money(int whole, int cent)
    {
        Whole = whole;
        Cent = cent;
    }

    public void Show()
    {
        Console.WriteLine($"{Whole}.{Cent}");
    }

    public int Whole
    {
        get => whole;
        set 
        {
            if (value < 0)
                throw new Exception("The value cannot be negative!");

            whole = value;
        }
    }

    public int Cent 
    { 
        get => cent;
        set
        {
            if (value < 0)
                throw new Exception("The value cannot be negative!");

            cent = value;
        }
    }
}

public class Product
{
    private string name;
    public Money price;

    public Product (string name, Money price)
    {
        Name = name;
        this.price = price;
    }

    public void ReducePrice(int removedWhole, int removedCents)
    {
        int newCent = price.Cent - removedCents;
        int newWhole = price.Whole - removedWhole;

        if (newCent < 0)
        {
            newWhole -= 1;
            newCent += 100;
        }

        if (newWhole < 0)
            throw new Exception("Price cannot be negative!");

        price.Whole = newWhole;
        price.Cent = newCent;
    }

    public void Show()
    {
        Console.Write($"{name} - ");
        price.Show();
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
}

internal class task1
{
    static void Main(string[] args)
    {
        try
        {
            var USD = new Money(100, 25);
            USD.Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        var product = new Product("TV", new Money(20, 10));
        product.ReducePrice(1, 20);
        product.Show();
    }
}
