using System;

namespace dataStructuresCsharp.LinkedList
{
    public class SinglyLinkedList<T>
    {
        private Node<T> _head;
        
        public SinglyLinkedList()
        {
            _head = null;
        }

        public void AddToTheEnd(T value){
            if (_head == null){
                _head = new Node<T>(value);
                return;
            }

            while(_head.Next != null){
                _head = _head.Next;
            }

            _head.Next = new Node<T>(value);    
        }

        public void Display(){
            var count = 0;
            while(_head != null){
                Console.WriteLine($"Node {count}, Value: {_head.Value}");
                _head = _head.Next;
                count++;
            }
        }
    }
}