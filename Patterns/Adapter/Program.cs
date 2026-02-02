namespace Adapter;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Старий спосіб (якби ми писали прямо)
        // var writer = new FileWriter();
        // writer.WriteLine("Test");

        // Новий спосіб (через універсальний інтерфейс)
        ILogger logger = new FileLoggerAdapter(new FileWriter());

        logger.Log("Користувач увійшов у систему");
        logger.Error("Зв'язок з базою даних втрачено");
    }
}
