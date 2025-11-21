Console.Write("Enter value: ");
double number = double.Parse(Console.ReadLine());
Console.Write("Enter percentage: ");
double percentages = double.Parse(Console.ReadLine());

double result = number * (percentages / 100);

Console.WriteLine($"{percentages} percent of {number} = {result}");
