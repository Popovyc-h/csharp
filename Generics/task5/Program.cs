namespace DoublyLinkedList;

internal class Program
{
    static void Main(string[] args)
    {
        var list = new DoublyLinkedList<int>();

        list.AddFirst(10);
        list.AddFirst(12);
        list.AddFirst(14);
        list.AddFirst(16);

        list.Print();

        list.AddLast(0);

        list.Print();

        list.RemoveFirst();
        list.RemoveLast();

        list.Print();
    }
}
