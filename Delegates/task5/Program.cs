namespace MulticastDelegates;

internal class Program
{
    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static void WriteToFile(string text)
    {
        File.AppendAllText("text.txt", text);
    }

    static void Main(string[] args)
    {
        Action<string> p = Print;
        Console.Write("Enter message: ");
        p += WriteToFile;

        string message = Console.ReadLine();
        p(message);
    }
}
