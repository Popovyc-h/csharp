Console.Write("Введіть число від 1 до 100: ");
int number = int.Parse(Console.ReadLine());

if (number <= 0 || number > 100)
    Console.WriteLine("Помилка! Введіть число від 1 до 100");
else
{
    if (number % 3 == 0 && number % 5 == 0)
        Console.WriteLine("Fizz Buzz");
    else if (number % 5 == 0)
        Console.WriteLine("Buzz");
    else if (number % 3 == 0)
        Console.WriteLine("Fizz");
    else
        Console.WriteLine(number);
}
