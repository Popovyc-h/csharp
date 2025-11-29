int[,] matrix1 =
{
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
};

int[,] matrix2 =
{
            {99, 82, 73},
            {64, 55, 46},
            {37, 28, 19}
};

Console.WriteLine("Default matrix");
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
        Console.Write(matrix1[i, j] + " ");
    Console.WriteLine();
}

Console.Write("\nEnter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"\nMatrix multiplied by a number {number}");

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
        Console.Write(matrix1[i, j] * number + " ");
    Console.WriteLine();
}

int rows = matrix1.GetLength(0);
int columns = matrix1.GetLength(1);

int[,] C = new int[rows, columns];

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        C[i, j] = matrix1[i, j] + matrix2[i, j];

Console.WriteLine("\nSum of matrices");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write(C[i, j] + " ");
    Console.WriteLine();
}

int[,] D = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < D.GetLength(0); i++)
    for (int j = 0; j < D.GetLength(1); j++)
        for (int k = 0; k < matrix1.GetLength(1); k++)
            D[i, j] += matrix1[i, k] * matrix2[k, j];

Console.WriteLine("\nProduct of matrices");
for (int i = 0; i < D.GetLength(0); i++)
{
    for (int j = 0; j < D.GetLength(1); j++)
        Console.Write(D[i, j] + " ");
    Console.WriteLine();
}
