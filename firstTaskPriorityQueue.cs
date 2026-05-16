using System;
using System.Collections.Generic;
using System.Linq;

public class PriorityQueue<T>
{
    private readonly Func<T, int> _prioritySelector;
    private readonly List<(T item, int priority, int order)> _items;
    private int _orderCounter;

    public PriorityQueue(Func<T, int> prioritySelector)
    {
        _prioritySelector = prioritySelector ?? throw new ArgumentNullException(nameof(prioritySelector));
        _items = new List<(T, int, int)>();
        _orderCounter = 0;
    }

    public void Enqueue(T item)
    {
        int priority = _prioritySelector(item);
        _items.Add((item, priority, _orderCounter++));
    }

    public T Dequeue()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        var maxItem = _items
            .OrderByDescending(x => x.priority)
            .ThenBy(x => x.order)
            .First();
        
        _items.Remove(maxItem);
        return maxItem.item;
    }

    public T Peek()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        return _items
            .OrderByDescending(x => x.priority)
            .ThenBy(x => x.order)
            .First().item;
    }

    public int Count => _items.Count;
    public bool IsEmpty => _items.Count == 0;
}
class Program
{
    static void Main()
    {
        // Просто чтобы программа компилировалась
        Console.WriteLine("PriorityQueue<T> class готов для исп");
    }
}