namespace Adapter;

// 2. Adaptee (Стороння бібліотека, яку треба адаптувати)
// Уявіть, що цей код ви не можете змінювати
public class FileWriter
{
    public void Write(string text)
    {
        Console.Write(text);
    }

    public void WriteLine(string text)
    {
        Console.WriteLine($"[FILE] >> {text}");
    }
}
