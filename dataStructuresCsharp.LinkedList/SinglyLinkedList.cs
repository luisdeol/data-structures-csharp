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

            var currentNode = _head;
            while(currentNode.Next != null){
                currentNode = currentNode.Next;
            }

            currentNode.Next = new Node<T>(value);    
        }

        public void AddToTheBeginning(T value){
            var newNode = new Node<T>(value);

            if (_head == null) {
                _head = newNode;
                return;
            }

            var oldHead = _head;
            _head = newNode;
            newNode.Next = oldHead;
        }

        public void AddToNthPosition(int position, T value){
            var count = 0;
            var newNode = new Node<T>(value);

            if (_head == null){
                _head = newNode;
                return;
            }
            
            if (_head.Next == null){
                _head.Next = newNode;
                return;
            }

            if (position == 0){
                var oldHead = _head;
                _head = newNode;
                newNode.Next = oldHead;
            }
            
            var current = _head;
            while(count < position-1){
                if (current.Next == null){
                    current.Next = newNode;
                    return;
                }
                count++;
                current = current.Next;
            }

            var oldNthNode = current.Next;
            var oldNthNextNode = oldNthNode.Next;
            current.Next = newNode;
            newNode.Next = oldNthNextNode;
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