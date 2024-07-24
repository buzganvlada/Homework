using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        var intQueue = new PriorityQueue<int>();
        intQueue.Enqueue(5, 2);
        intQueue.Enqueue(8, 1);
        intQueue.Enqueue(2, 3);

        Console.WriteLine(intQueue.Dequeue());    
        Console.WriteLine(intQueue.Peek());       
        Console.WriteLine(intQueue.Dequeue());    
        Console.WriteLine(intQueue.Dequeue()); 

        var stringQueue = new PriorityQueue<string>();
        stringQueue.Enqueue("high priority", 3);
        stringQueue.Enqueue("low priority", 1);
        stringQueue.Enqueue("medium priority", 2);

        Console.WriteLine(stringQueue.Dequeue()); 
        Console.WriteLine(stringQueue.Peek());    
        Console.WriteLine(stringQueue.Dequeue()); 
        Console.WriteLine(stringQueue.Dequeue()); 
    }
}
