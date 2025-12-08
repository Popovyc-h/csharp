namespace Product;

public abstract class Product
{
    public string name;
    public double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public abstract double CalculateDiscount();
}

public class Electronics : Product
{
    public Electronics(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.10;
    }
}

public class Furniture : Product
{
    public Furniture(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.15;
    }
}

internal class task6
{
    static void Main(string[] args)
    {
        var products = new List<Product>
        {
            new Electronics("TV Samsung", 15000.0),
            new Electronics("Laptop Lenovo", 45000.0),
            new Furniture("The sofa is folding", 1000.0),
            new Furniture("Dining table", 800.0)
        };

        foreach (var product in products)
        {
            double discount = product.CalculateDiscount();
            Console.WriteLine($"{product.name}: price {product.price} -> discount {discount}");
        }
    }
}
