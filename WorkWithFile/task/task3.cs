var file = "log.txt";

while (true)
{
    Console.WriteLine("Введіть повідомлення: ");
    var line = Console.ReadLine();
    File.AppendAllText(file, line + " ");
    Console.WriteLine($"Вміст файлу: {File.ReadAllText("log.txt")}");
}
