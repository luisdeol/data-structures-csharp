using System;

namespace dataStructuresCsharp.Queue
{
    public class Queue<T>
    {
        private T[] _array;
        private int _count = 0;
        private int _head = 0;

        public Queue()
        {       
            _array = new T[1];
        }

        public void Enqueue(T value){
            if (_count+_head == _array.Length)
                Resize(_array.Length*2);

            _array[_count++] = value;
        }
        
        public T Dequeue(){
            if (_head+_count == 0){
                Console.WriteLine("Queue is empty!");
            }

            if (_count == _array.Length/2)
                Resize(_array.Length/2);

            _count--;
            return _array[_head++];
        }
        
        private void Resize(int size){
            var newArray = new T[size];

            var indexNewArray = 0;

            for(int i=_head; i < _head+_count; i++){
                newArray[indexNewArray] = _array[i];
                indexNewArray++;
            }

            _array = newArray;
            _head = 0;
        }
        public void Display(){
            for(int i=_head; i < _head+_count; i++){
                if (_array[i]==null)
                    break;

                Console.WriteLine(_array[i]);
            }

            Console.WriteLine($"Queue size is {_count}");
        }
    }
}