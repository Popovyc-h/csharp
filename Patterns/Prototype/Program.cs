namespace Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        var dolly = new Sheep("Доллі", 3);
        var molly = dolly.Clone();

        Console.WriteLine($"Доллі: {dolly.Name}, {dolly.Age}");
        Console.WriteLine($"Моллі: {molly.Name}, {molly.Age}");
        
        Console.WriteLine();
        molly.Name = "Моллі";
        molly.Age = 12;

        Console.WriteLine($"Доллі: {dolly.Name}, {dolly.Age}");
        Console.WriteLine($"Моллі: {molly.Name}, {molly.Age}");
    }
}
