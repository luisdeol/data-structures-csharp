using System;

namespace dataStructuresCsharp.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var singlyLinkedList = new SinglyLinkedList<string>();
            singlyLinkedList.AddToTheEnd("Hello");
            singlyLinkedList.AddToTheBeginning("Luis");
            singlyLinkedList.AddToTheEnd("World");
            singlyLinkedList.AddToTheBeginning("Head");
            singlyLinkedList.AddToNthPosition(0,"3th position node");
            singlyLinkedList.Display();
        }
    }
}
