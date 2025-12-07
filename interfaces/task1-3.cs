namespace xxx;

public interface IMath
{
    public int Max();
    public int Min();
    public float Avg();
    public bool Search(int valueToSearch);
}

public interface IOutput
{
    void Show();
    void Show(string info);
}

public interface ISort
{
    public void SortAsc();
    public void SortDesc();
    public void SortByParam(bool isAsc);
}

class Array : IOutput, IMath, ISort
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

    public void Show()
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }

    public void Show(string info)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine($"\n{info}");
    }

    public int Max()
    {
        return arr.Max();
    }

    public int Min()
    {
        return arr.Min();
    }

    public float Avg()
    {
        float sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];

        return sum / arr.Length;
    }

    public bool Search(int valueToSearch)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == valueToSearch)
                return true;
        }
        return false;
    }

    public void SortAsc()
    {
        System.Array.Sort(arr);
    }

    public void SortDesc()
    {
        System.Array.Sort(arr);
        System.Array.Reverse(arr);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc == true)
            SortAsc();
        else
            SortDesc();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Array array = new Array([2, 1, 4, 3, 5]);
        array.Show();
        Console.WriteLine();
        array.Show("Info");

        Console.WriteLine($"Max: {array.Max()}");
        Console.WriteLine($"Min: {array.Min()}");
        Console.WriteLine($"Avg: {array.Avg()}");
        Console.WriteLine(array.Search(9));

        Console.WriteLine("SortAsc");
        array.SortAsc();
        array.Show();

        Console.WriteLine("\nSortDesc");
        array.SortDesc();
        array.Show();

        Console.WriteLine("\nSortByParam");
        array.SortByParam(true);
        array.Show();

    }
}
