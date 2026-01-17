namespace WorkWithFiles;

internal class Program
{
    static void Main(string[] args)
    {
        var filePath = "comment.txt";
        var newFilePath = "clean_comment.txt";

        var content = new[]
            {
            "This code works perfectly fine. There are no bugs in the implementation.",
            "I tested everything and found a small bug in the login function.",
            "The bug appears only when you enter special characters.",
            "After fixing that bug, the system runs smoothly.",
            "No more bugs detected during testing."
        };

        File.WriteAllLines(filePath, content);

        Console.WriteLine("Вміст оригінального файлу:");

        var read = File.ReadAllLines(filePath);
        foreach (var r in read)
            Console.WriteLine(r);
        
        var text = File.ReadAllText(filePath);
        var cleanText = text.Replace("bug", "***");

        File.WriteAllText(newFilePath, cleanText);
        
        Console.WriteLine("\nВміст відредагованого файлу:");
        Console.WriteLine(File.ReadAllText(newFilePath));
    }
}
