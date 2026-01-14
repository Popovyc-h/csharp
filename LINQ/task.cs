Console.WriteLine("Level 1:");
// Підрахунок слів (String Extension).
var text = "Hello world from C# extension";
var count = text.WordCount();
Console.WriteLine($"Count: {count}");

// Пошук парних (Basic LINQ).
int[] numbers = { 1, 5, 8, 12, 3, 20 };
var isEven = numbers.Where(n => n > 5 && n % 2 == 0).ToList();
isEven.ForEach(n => Console.Write(n + " "));

// Конвертер валюти (Decimal Extension).
var price = 100.5m;
var uah = price.ToUAH(41.5m);
Console.WriteLine($"\nUAH: {uah}");

Console.WriteLine("\nLevel 2:"); // Рівень 2:
var products = new List<Product>
{
    new Product { Name = "Laptop", Category = "Electronics", Price = 35000m, Stock = 5 },
    new Product { Name = "Mouse", Category = "Electronics", Price = 500m, Stock = 30 },
    new Product { Name = "Keyboard", Category = "Electronics", Price = 1200m, Stock = 0 },
    new Product { Name = "Office Chair", Category = "Furniture", Price = 4200m, Stock = 7 },
    new Product { Name = "Desk Lamp", Category = "Furniture", Price = 900m, Stock = 12 },
    new Product { Name = "Notebook", Category = "Stationery", Price = 60m, Stock = 100 }
};

// Інвентаризація
var electronicsInStockDesc = products.Where(e => e.Category == "Electronics" && e.Stock > 0).OrderByDescending(e => e.Price).ToList();
electronicsInStockDesc.ForEach(e => Console.WriteLine($"{e.Name} - {e.Category} - {e.Price} - {e.Stock}"));

Console.WriteLine();

// Список цінників
var priceTags = products.Select(p => $"Товар: {p.Name} - {p.Price} грн").ToList();
priceTags.ForEach(p => Console.WriteLine(p));

// Безпечний список
List<int> number = null;
foreach (var n in number.SafeEmpty())
    Console.WriteLine(n);

Console.WriteLine("\nLevel 3:");// Рівень 3:

//Звіт по категоріях
var result = products
    .GroupBy(p => p.Category)
    .Select(p => new
    {
        name = p.Key,
        count = p.Count(),
        average = p.Average(items => items.Price)
    })
    .ToList();

result.ForEach(r => Console.WriteLine($"{r.name}, {r.count}, {r.average:F}"));

// Пагінація

var page1 = products.Page(1, 2);
var page2 = products.Page(2, 2);

Console.WriteLine("\nPage 1:");
foreach (var p in page1)
    Console.WriteLine($"{p.Name} - {p.Price}");

Console.WriteLine("\nPage 2:");
foreach (var p in page2)
    Console.WriteLine($"{p.Name} - {p.Price}");
Console.WriteLine();

// Перевірка наявності (Any/All)
var allProductsInStock = products.All(p => p.Stock > 0);
var containsExpensiveItem = products.Any(p => p.Price > 10000);

Console.WriteLine($"All products: {allProductsInStock}");
Console.WriteLine($"Price > 10 000: {containsExpensiveItem}");

public static class Convert // Конвертер валюти (Decimal Extension).
{
    public static decimal ToUAH(this decimal amount, decimal rate)
    {
        return amount * rate;
    }
}

public static class StringExtensions // Пошук парних (Basic LINQ).
{
    public static int WordCount(this string str)
    {
        var count = str.Split(' ');
        return count.Length;
    }
}

public class Product // Рівень 2:
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

public static class SafeList
{
    public static IEnumerable<T> SafeEmpty<T>(this IEnumerable<T> source)
    {
        if (source == null)
            return Enumerable.Empty<T>();
        else
            return source;
    }
} // Безпечний список

public static class PaginationExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
    }
}
