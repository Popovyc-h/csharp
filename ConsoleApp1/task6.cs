Console.WriteLine("1. Convert from Fahrenheit to Celsius");
Console.WriteLine("2. Convert from Celsius to Fahrenheit");
Console.Write("Your choice: ");
int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.Write("Temperature in Fahrenheit: ");
    double temperature = double.Parse(Console.ReadLine());
    double celsius = (temperature - 32) * 5 / 9;
    Console.WriteLine($"{temperature} degrees Fahrenheit = {celsius:F1} degrees Celsius");
}
else if (choice == 2)
{
    Console.Write("Temperature in Celsius: ");
    double temperature = double.Parse(Console.ReadLine());
    double fahrenheit = temperature * 9 / 5 + 32;
    Console.WriteLine($"{temperature} degrees Celsius = {fahrenheit:F1} degrees Fahrenheit");
}
else
    Console.WriteLine("Invalid choice!");
