int[] arr1 = { 1, 2, 6, -1, 88, 7, 6 };
int[] arr2 = { 6, 88, 7 };

int[] result = arrayFilter(arr1, arr2);

Console.WriteLine("Original array");
for (int i = 0; i < arr1.Length; i++)
    Console.Write(arr1[i] + " ");

Console.WriteLine("\n\nElements to remove");
for (int i = 0; i < arr2.Length; i++)
    Console.Write(arr2[i] + " ");

Console.WriteLine("\n\nResult");
for (int i = 0; i < result.Length; i++)
    Console.Write(result[i] + " ");

int[] arrayFilter(int[] original, int[] toRemove)
{
    int resultSize = 0;

    for (int i = 0; i < original.Length; i++)
    {
        bool found = false;
        for (int j = 0; j < toRemove.Length; j++)
        {
            if (original[i] == toRemove[j])
            {
                found = true;
                break;
            }
        }
        if (!found)
            resultSize++;
    }

    int[] result = new int[resultSize];

    int index = 0;
    for (int i = 0; i < original.Length; i++)
    {
        bool found = false;
        for (int j = 0; j < toRemove.Length; j++)
        {
            if (original[i] == toRemove[j])
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            result[index] = original[i];
            index++;
        }
    }

    return result;
}
