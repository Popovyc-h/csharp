namespace WorkWithFiles;

internal class Program
{
    static void Main(string[] args)
    {
        var directoryPath = "MyDocuments";
        var filePath = "MyDocuments/";

        Directory.CreateDirectory(directoryPath);

        File.WriteAllText(filePath + "test1.txt", "1");
        File.WriteAllText(filePath + "test2.txt", "22");
        File.WriteAllText(filePath + "test3.txt", "3");
        File.WriteAllText(filePath + "test4.txt", "4");
        File.WriteAllText(filePath + "test5.txt", "!ass@dk");

        var listOfFiles = Directory.GetFiles(directoryPath);

        Console.WriteLine($"Список усіх файлів в папці {directoryPath}");

        foreach (var f in listOfFiles)
        {
            FileInfo fileInfo = new FileInfo(f);
            Console.WriteLine($"{fileInfo.Name} - {fileInfo.Length}");
        }
    }
}
