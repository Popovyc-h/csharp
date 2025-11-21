Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i < number; i++)
    if (number % i == 0)
        sum += i;

if (number == sum)
    Console.WriteLine("The number is perfect");
else
    Console.WriteLine("The number is not perfect");
