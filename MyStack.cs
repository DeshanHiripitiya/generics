public class MyStack<T>
{
    private readonly List<T> items = new();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        int lastIndex = items.Count - 1;
        T item = items[lastIndex];
        items.RemoveAt(lastIndex);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        return items[^1];
    }

    public int Count => items.Count;
    public bool IsEmpty => Count == 0;
}