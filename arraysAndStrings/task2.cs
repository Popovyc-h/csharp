using System;

int[,] array = new int[5, 5];
Random rand = new Random();

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = rand.Next(-101, 101);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}

int minValue = array[0, 0];
int maxValue = array[0, 0];
int minI = 0;
int minJ = 0;
int maxI = 0;
int maxJ = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(minValue > array[i, j])
        {
            minValue = array[i, j];
            minI = i;
            minJ = j;
        }

        if (maxValue < array[i, j])
        {
            maxValue = array[i, j];
            maxI = i;
            maxJ = j;
        }
    }
}

int minIndex = minI * 5 + minJ;
int maxIndex = maxI * 5 + maxJ;
int temp;
int sum = 0;

if (minIndex > maxIndex)
{     
    temp = minIndex;
    minIndex = maxIndex;
    maxIndex = temp;
}

for (int i = minIndex + 1; i < maxIndex; i++)
{
    int row = i / 5;
    int col = i % 5;

    sum += array[row, col];
}

Console.WriteLine($"Sum of array elements: {sum}");
