int[,] matrix =
{
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
};

int[,] B = 
{
            {99, 82, 73},
            {64, 55, 46},
            {37, 28, 19}
};

Console.WriteLine("Default matrix");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + " ");
    Console.WriteLine();
}

Console.Write("\nEnter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"\nMatrix multiplied by a number {number}");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] * number + " ");
    Console.WriteLine();
}

int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);

int[,] C = new int[rows, columns];

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        C[i, j] = matrix[i, j] + B[i, j];

Console.WriteLine("\nSum of matrices");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write(C[i, j] + " ");
    Console.WriteLine();
}

int[,] D = new int[matrix.GetLength(0), B.GetLength(1)];

for (int i = 0; i < D.GetLength(0); i++)
    for (int j = 0; j < D.GetLength(1); j++)
        for (int k = 0; k < matrix.GetLength(1); k++)
            D[i, j] += matrix[i, k] * B[k, j];

Console.WriteLine("\nProduct of matrices");
for (int i = 0; i < D.GetLength(0); i++)
{
    for (int j = 0; j < D.GetLength(1); j++)
        Console.Write(D[i, j] + " ");
    Console.WriteLine();
}
