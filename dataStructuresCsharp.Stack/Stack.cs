using System;

namespace dataStructuresCsharp.Stack
{
    public class Stack<T>
    {
        private T[] _array;
        private int top = -1;
        public Stack(int size)
        {
            _array = new T[size];
        }

        public void Push(T value){
            if (_array.Length-1 == top){
                IncreaseArraySize();
            }

            top++;
            _array[top] = value;
        }

        public T Pop(){            
            var oldTop = top--;
            var oldTopValue = _array[oldTop];

            var halfLength = (float)_array.Length / 2;

            if (top+1 < halfLength)
                DecreaseArraySize();

            return _array[oldTop];
        }
        private void IncreaseArraySize(){
            var newSize = _array.Length * 2;
            var newArray = new T[newSize];

            for(int i=0; i < _array.Length; i++)
                newArray[i] = _array[i];
            
            _array = newArray;
        }

        private void DecreaseArraySize(){
            var newSize = _array.Length/2;
            var newArray = new T[newSize];

            for(int i=0; i < newSize; i++)
                newArray[i] = _array[i];
            
            _array = newArray;
        }

        public void Display(){
            for(int i=0; i <= top; i++){
                if (_array[i]==null)
                    break;

                Console.WriteLine(_array[i]);
            }

            Console.WriteLine($"Stack size is {_array.Length}");
        }
    }
}