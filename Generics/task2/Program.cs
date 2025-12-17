namespace QueueWithPriorities;

internal class Program
{
    static void Main(string[] args)
    {
        var queue = new PriorityQueue<int>();

        queue.Enqueue(5, 6);
        queue.Enqueue(20, 3);
        queue.Enqueue(10, 1);

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        try
        {
            Console.WriteLine(queue.Dequeue());
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
