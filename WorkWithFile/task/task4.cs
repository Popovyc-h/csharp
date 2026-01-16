namespace xxx;

internal class Program
{
    static void Main(string[] args)
    {
        var filePath = "sales.csv";
        string[] lines = { "Milk,25", "Bread,12", "Eggs,40" };
        int total = 0;

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не знайдено, створюю новий...");
            File.WriteAllLines(filePath, lines);
        }

        var csvLines = File.ReadAllLines(filePath);
        foreach (var l in csvLines)
            Console.WriteLine(l);

        foreach (var line in csvLines)
        {
            var parts = line.Split(',');
            total += int.Parse(parts[1]);
        }
        Console.WriteLine($"Загальна сума: {total}");
    }
}
