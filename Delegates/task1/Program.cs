namespace MethodsForWorkingWithArrays;

delegate bool ArrayCondition(int value);

internal class Program
{
    public static bool IsEven(int value) => value % 2 == 0;

    public static bool IsOdd(int value) => value % 2 != 0;

    public static bool IsPrime(int value)
    {
        if (value <= 1) return false;
        if (value == 2) return true;
        if (value % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(value); i += 2)
        {
            if (value % i == 0)
                return false;
        }
        return true;
    }

    public static bool IsFibonacci(int value)
    {
        if (value < 0) return false;
        if (value == 0 || value == 1) return true;

        int a = 0;
        int b = 1;

        while (b < value)
        {
            int nex = a + b;
            a = b;
            b = nex;
        }

        return b == value;
    }

    public static int[] Filter(int[] numbers, ArrayCondition condition)
    {
        List<int> result = new();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (condition(numbers[i]))
                result.Add(numbers[i]);
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };

        int[] eventNumbers = Filter(array, IsEven);
        int[] oddNumbers = Filter(array, IsOdd);
        int[] primeNumbers = Filter(array, IsPrime);
        int[] fibonacciNumbers = Filter(array, IsFibonacci);

        foreach (var num in eventNumbers)
            Console.Write(num + " ");

        Console.WriteLine();

        foreach (var num in oddNumbers)
            Console.Write(num + " ");

        Console.WriteLine();

        foreach (var num in primeNumbers)
            Console.Write(num + " ");

        Console.WriteLine();

        foreach (var num in fibonacciNumbers)
            Console.Write(num + " ");
    }
}
