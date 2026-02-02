namespace Adapter;

// 3. Adapter
public class FileLoggerAdapter : ILogger
{
    private readonly FileWriter _fileWriter;

    public FileLoggerAdapter(FileWriter fileWriter)
    {
        _fileWriter = fileWriter;
    }

    public void Log(string message)
    {
        // TODO: Перенаправити виклик до _fileWriter.WriteLine
        _fileWriter.WriteLine(message);
    }

    public void Error(string message)
    {
        // TODO: Перенаправити до _fileWriter, додавши префікс "ERROR: "
        _fileWriter.WriteLine($"ERROR: {message}");
    }
}
