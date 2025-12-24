namespace DataProcessingChainWithDelegates;

internal class Program
{
    public static void CheckPositive(int number, Action<int> next)
    {
        if (number > 0)
            next(number);
        else
            Console.WriteLine($"The number: {number} did not pass the positive test");
    }

    public static void CheckEven(int number, Action<int> next)
    {
        if (number % 2 == 0)
            next(number);
        else
            Console.WriteLine($"The number: {number} did not pass the even test");
    }

    public static void Final(int number, Action<int> next) 
    {
        Console.WriteLine($"Number {number} passed all checks");
    }

    static void Main(string[] args)
    {
        Action<int> ac1;
        Action<int> ac2;
        Action<int> ac3 = number => Final(number, null);

        ac2 = number => CheckEven(number, ac3);
        ac1 = number => CheckPositive(number, ac2);

        ac1(2);
        ac1(3);
        ac1(-3);
    }
}
