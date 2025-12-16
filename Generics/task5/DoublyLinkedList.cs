namespace DoublyLinkedList
{
    internal class DoublyLinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddFirst(T value)
        {
            var newNode = new Node<T>(value);

            if (head == null)
                head = tail = newNode;
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);

            if (head == null)
                head = tail = newNode;
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");

            if (head == tail)
                head = tail = null;
            else
            {
                head = head.Next;
                head.Prev = null;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");

            if (head == tail)
                head = tail = null;
            else
            {
                tail = tail.Prev;
                tail.Next = null;
            }
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
