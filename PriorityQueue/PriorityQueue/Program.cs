using System;

public class PriorityQueue<T>
{
   private class PriorityQueueItem
    {
        public T Item { get; set; }
        public int Priority { get; set; }
        public PriorityQueueItem(T item, int priority)
        {
            Item = item;
            Priority = priority;
        }
    }
    private List<PriorityQueueItem> _items = new List<PriorityQueueItem>();

    public void Enqueue(T item, int priority)
    {
        var newItem = new PriorityQueueItem(item, priority);
        _items.Add(newItem);
    }

    public T Dequeue()
    {
        if (_items.Count == 0) throw new InvalidOperationException("The queue does not have any items");

        var highPriorityItem = _items[0];
        foreach (var item in _items)
        {
            if (item.Priority > highPriorityItem.Priority)
            {
                highPriorityItem = item;
            }
        }

        _items.Remove(highPriorityItem);
        return highPriorityItem.Item;
    }

    public T Peek()
    {
        if (_items.Count == 0) throw new InvalidOperationException("The queue does not have any items");

        var highPriorityItem = _items[0];
        foreach (var item in _items)
        {
            if (item.Priority > highPriorityItem.Priority)
            {
                highPriorityItem = item;
            }
        }

        return highPriorityItem.Item;
    }

    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

}