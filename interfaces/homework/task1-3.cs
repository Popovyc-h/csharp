namespace xxx;

public interface ICalc
{
    public int Less(int valueToCompare);
    public int Greater(int valueToCompare);
}

public interface IOutput2
{
    public void ShowEven();
    public void ShowOdd();
}

public interface ICalc2
{
    public int CountDistinct();
    public int EqualToValue(int valueToCompare);
}

class Array : ICalc, IOutput2, ICalc2
{
    public int[] arr;

    public Array(int[] arr)
    {
        this.arr = arr;
    }

    public int this[int n]
    {
        get { return arr[n]; }
        set { arr[n] = value; }
    }

    public int Less(int valueToCompare)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] < valueToCompare)
                count++;

        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] > valueToCompare)
                count++;

        return count;
    }

    public void ShowEven()
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 0)
                Console.Write($"{arr[i]} ");
    }

    public void ShowOdd()
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 != 0)
                Console.Write($"{arr[i]} ");
    }

    public int CountDistinct()
    {
        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!list.Contains(arr[i]))
                list.Add(arr[i]);
        }

        return list.Count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == valueToCompare)
                count++;

        return count;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var array = new Array([2, 1, 2, 2, 3, 4, 5, 6]);
        Console.WriteLine($"Less: {array.Less(3)}");
        Console.WriteLine($"Greater: {array.Greater(3)}");
        Console.Write("Even numbers: ");
        array.ShowEven();
        Console.Write("\nOdd numbers: ");
        array.ShowOdd();
        Console.WriteLine($"\nNumber of unique values: {array.CountDistinct()}");
        Console.WriteLine($"Number of equal elements{2}: {array.EqualToValue(2)}");
    }
}
