Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

string numberStr = number.ToString();
int count = numberStr.Length;

int sum = 0;

for (int i = 0; i < count; i++)
{
    int digit = int.Parse(numberStr[i].ToString());
    int result = 1;

    for (int j = 0; j < count; j++)
        result *= digit;
    sum += result;
}

if (number == sum)
    Console.WriteLine("The number is an Armstrong number");
else
    Console.WriteLine("The number is NOT an Armstrong number");
