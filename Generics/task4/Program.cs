namespace SinglyLinkedList;

internal class Program
{
    static void Main(string[] args)
    {
        var n = new SinglyLinkedList<int>();

        n.AddFirst(2);
        n.AddFirst(1);
        n.AddFirst(9);
        n.AddLast(43);

        n.Print();
        
        n.RemoveFirst();
     
        n.Print();

        n.RemoveLast();

        n.Print();
    }
}
