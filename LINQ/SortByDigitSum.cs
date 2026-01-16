class Program
{
    static void Main()
    {
        int[] numbers = { 121, 75, 81 };

        var strNum = numbers.Select(n => n.ToString());

        var sumStr = strNum.Select(str => str.Select(c => c - '0').Sum()).OrderByDescending(n => n);

        Console.Write("numbers: ");
        foreach (var n in numbers)
            Console.Write(n + " ");

        Console.Write($"\nSum: ");
        foreach (var s in sumStr)
            Console.Write(s + " ");
    }
}
