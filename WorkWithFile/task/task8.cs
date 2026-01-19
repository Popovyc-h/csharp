namespace WorkWithFile;

internal class Program
{
    public static void workWithDirectory(string directoryPath)
    {

        Directory.CreateDirectory(Path.Combine(directoryPath, "Docs"));
        Directory.CreateDirectory(Path.Combine(directoryPath, "Images"));
        Directory.CreateDirectory(Path.Combine(directoryPath, "Misc"));

        var txtFiles = Directory.EnumerateFiles(directoryPath, "*.txt");
        var jpgFiles = Directory.EnumerateFiles(directoryPath, "*.jpg");
        var exeFiles = Directory.EnumerateFiles(directoryPath, "*.exe");
        var jsonFiles = Directory.EnumerateFiles(directoryPath, "*.json");

        foreach (var currentFile in txtFiles)
        {
            string fileName = Path.GetFileName(currentFile);
            File.Move(currentFile, Path.Combine(directoryPath, "Docs", fileName));
        }

        foreach (var currentFile in jpgFiles)
        {
            string fileName = Path.GetFileName(currentFile);
            File.Move(currentFile, Path.Combine(directoryPath, "Images", fileName));
        }

        foreach (var currentFile in exeFiles)
        {
            string fileName = Path.GetFileName(currentFile);
            File.Move(currentFile, Path.Combine(directoryPath, "Misc", fileName));
        }

        foreach (var currentFile in jsonFiles)
        {
            string fileName = Path.GetFileName(currentFile);
            File.Move(currentFile, Path.Combine(directoryPath, "Misc", fileName));
        }
    }

    static void Main(string[] args)
    {
        var dirPath = "Downloads";
        var filePath = "Downloads/";

        Directory.CreateDirectory(dirPath);
        File.WriteAllText(filePath + "test1.txt", " ");
        File.WriteAllText(filePath + "test2.txt", " ");
        File.WriteAllText(filePath + "test.jpg", " ");
        File.WriteAllText(filePath + "test.exe", " ");
        File.WriteAllText(filePath + "test.json", " ");

        workWithDirectory(dirPath);
    }
}
