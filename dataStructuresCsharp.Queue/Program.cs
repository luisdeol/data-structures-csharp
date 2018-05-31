using System;

namespace dataStructuresCsharp.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue("4");
            queue.Dequeue();
            queue.Enqueue("5");
            
            queue.Display();
        }
    }
}
