namespace QueueWithPriorities;

internal class PriorityItem<T>
{
    public T Value;
    public int Priority;

    public PriorityItem(T value, int priority)
    {
        Value = value;
        Priority = priority;
    }
}
