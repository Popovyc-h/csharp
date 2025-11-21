Console.Write("Enter a number from 1 to 100: ");
int number = int.Parse(Console.ReadLine());

if (number <= 0 || number > 100)
    Console.WriteLine("Error! Please enter a number from 1 to 100");
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
