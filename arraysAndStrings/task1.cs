double[] A = new double[5];
double[,] B = new double[3, 4];

double product = 1.0;

Console.WriteLine("Fill the array");
for (int i = 0; i < A.Length; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    A[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("\nArray A:");
foreach (var n in A)
    Console.Write(n + " ");

Random rand = new Random();

for (int i = 0; i < B.GetLength(0); i++)
    for (int j = 0; j < B.GetLength(1); j++)
        B[i, j] = rand.Next(1, 101);

Console.WriteLine("\n\nArray B:");
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
        Console.Write(B[i, j] + " ");
    Console.WriteLine();
}

double maxA = A[0];
double maxB = B[0, 0];
double maxElement;

double minA = A[0];
double minB = B[0, 0];
double minElement;

double sum = 0;
double sumEvenA = 0;
double sumOddColumnsB = 0;

for (int i = 0; i < A.Length; i++)
{   
    if (maxA < A[i])
        maxA = A[i];

    if (minA > A[i])
        minA = A[i];

    sum += A[i];
    product *= A[i];

    if (A[i] % 2 == 0)
        sumEvenA += A[i];
}

for (int i = 0; i < B.GetLength(0); i++)
    for (int j = 0; j < B.GetLength(1); j++)
     {   
        if (maxB < B[i, j])
            maxB = B[i, j];

        if (minB > B[i, j])
            minB = B[i, j];

        sum += B[i, j];
        product *= B[i, j];

        if (j % 2 == 1)
            sumOddColumnsB += B[i, j];
    }

if (maxA > maxB)
    maxElement = maxA;
else
    maxElement = maxB;

if (minA < minB)
    minElement = minA;
else
    minElement = minB;

Console.WriteLine($"\nMax element: {maxElement}");
Console.WriteLine($"\nMin element: {minElement}");
Console.WriteLine($"\nTotal amount: {sum}");
Console.WriteLine($"\nTotal product: {product:F2}");
Console.WriteLine($"\nSum of even elements of array A: {sumEvenA}");
Console.WriteLine($"\nSum of odd columns of array B: {sumOddColumnsB}");
