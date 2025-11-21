Console.Write("Enter the start of the range: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Enter the end of the range: ");
int end = int.Parse(Console.ReadLine());

if (start > end)
{
    int temp = start;
    start = end;
    end = temp;
}

for (; start <= end; start++)
    if (start % 2 == 0)
        Console.Write($"{start} ");
