namespace Proxy;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Клієнт працює через проксі
        IVideoService manager = new CachedVideoService(new RealVideoService());

        Console.WriteLine("Запит відео #10:");
        Console.WriteLine(manager.GetVideo(10));

        Console.WriteLine("\nЗапит відео #10 (повторно):");
        Console.WriteLine(manager.GetVideo(10)); // Має бути миттєво
    }
}
