using System;

namespace dataStructuresCsharp.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var singlyLinkedList = new SinglyLinkedList<string>();
            singlyLinkedList.AddToTheEnd("Hello");
            singlyLinkedList.AddToTheEnd("World");

            singlyLinkedList.Display();
        }
    }
}
