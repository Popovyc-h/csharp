namespace Composite;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створення файлової структури
        var root = new Directory("Root");
        var movie = new File("Inception.mkv", 2000);

        var docsFolder = new Directory("Documents");
        docsFolder.Add(new File("Resume.pdf", 10));
        docsFolder.Add(new File("Picture.png", 5));

        root.Add(movie);
        root.Add(docsFolder);

        Console.WriteLine($"Загальний розмір Root: {root.GetSize()} MB");
        // Очікується: 2015 MB
    }
}
