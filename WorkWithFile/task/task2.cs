if (File.Exists("config.txt"))
    Console.WriteLine(File.ReadAllText("config.txt"));
else
{
    Console.WriteLine("Файл конфігурації не знайдено, створюю новий...");
    File.WriteAllText("config.txt", "DarkMode=False");
    Console.WriteLine(File.ReadAllText("config.txt"));
}
