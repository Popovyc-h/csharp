namespace QueueWithPriorities;

internal class PriorityQueue<T>
{
    public List<PriorityItem<T>> items;

    public PriorityQueue()
    {
        items = new List<PriorityItem<T>>();
    }

    public void Enqueue(T value, int priority)
    {
        var item = new PriorityItem<T>(value, priority);

        items.Add(item);
    }

    public T Dequeue()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        var bestIndex = 0;
        var bestPriority = items[0].Priority;

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Priority < bestPriority)
            {
                bestIndex = i;
                bestPriority = items[i].Priority;
            }
        }

        var value = items[bestIndex].Value;

        items.RemoveAt(bestIndex);

        return value;
    }
}
