int rows;
int columns;
int multiplier;
Random rand = new Random();

Console.Write("Enter size rows: ");
rows = int.Parse(Console.ReadLine());

Console.Write("Enter size columns: ");
columns = int.Parse(Console.ReadLine());

Console.Write("Enter multiplier: ");
multiplier = int.Parse(Console.ReadLine());

int[,] result = createRandomMatrix(rows, columns, multiplier);

Console.WriteLine("\nArray:");
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
        Console.Write(result[i, j] + " ");
    Console.WriteLine();
}

int[,] createRandomMatrix(int rows, int columns, int multiplier)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rand.Next(1, 11) * multiplier;

    return array;
}
