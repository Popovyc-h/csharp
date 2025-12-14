using System.Xml.Linq;

namespace circularQueue
{
    internal class CircularQueue<T>
    {
        private T[] queue;
        private int front;
        private int rear;
        private int count;

        public CircularQueue(int capacity)
        {
            queue = new T[capacity];
            front = 0;
            rear = 0;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full");

            queue[rear] = item;
            rear++;

            if (rear > queue.Length - 1)
                rear = 0;

            count++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            T item = queue[front];
            front++;

            if (front > queue.Length - 1)
                front = 0;

            count--;

            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return queue[front];
        }

        public bool IsEmpty()
        {
            if (count == 0)
                return true;

            return false;
        }

        public bool IsFull()
        {
            if (count == queue.Length)
                return true;

            return false;
        }
    }
}
