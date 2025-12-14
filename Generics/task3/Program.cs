namespace circularQueue;

internal class Program
{
    static void Main(string[] args)
    {
        var intQueue = new CircularQueue<int>(4);
        var stringQueue = new CircularQueue<string>(10);

        try
        {
            intQueue.Enqueue(99);
            intQueue.Enqueue(4);
            intQueue.Enqueue(5);
            intQueue.Enqueue(52);
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Використовуємо метод Peek: {intQueue.Peek()}");



        Console.WriteLine("\nСпроба видалити елемент з пустої черги");
        try
        {
            stringQueue.Dequeue();
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nВикористовуємо метод Peek в пустій черзі");
        try
        {
            stringQueue.Peek();
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(intQueue.IsFull());
        Console.WriteLine(stringQueue.IsFull());
    }
}
