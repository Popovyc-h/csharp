namespace SinglyLinkedList
{
    internal class SinglyLinkedList<T>
    {
        public Node<T> head;

        public SinglyLinkedList()
        {
            head = null;
        }

        public void AddFirst(T value)
        {
            var newNode = new Node<T>(value);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");

            head = head.Next;
        }

        public void RemoveLast()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node<T> current = head;

            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

        public void Print()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
