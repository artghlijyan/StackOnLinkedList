using System;
using System.Collections.Generic;

namespace StackOnLinkedList
{
    class Stack<T>
    {
        private LinkedList<T> _items = new LinkedList<T>();

        private bool IsEmpaty { get => _items.Count == 0; }

        public int Capacity { get; private set; }

        public int Count { get => _items.Count; }

        public Stack()
        {
            Capacity = 10;
        }

        public Stack(int capacity)
        {
            if (capacity < 0)
                throw new Exception();

            if (capacity <= 10)
                Capacity = 10;

            else
                Capacity = capacity;
        }

        public void Push(T value)
        {
            if (Count == Capacity)
                return;

            _items.AddLast(value);
        }

        public T Pop()
        {
            if (IsEmpaty)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }

            T result = _items.Last.Value;
            _items.RemoveLast();
            return result;
        }

        public T Peek()
        {
            return _items.Last.Value;
        }

        public void Clear()
        {
            _items = null;
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex) 
        {
            _items.CopyTo(array, arrayIndex);
        }

        public T[] ToArray()
        {
            T[] arr = { };
            _items.CopyTo(arr, 0);
            return arr;
        }

    }
}
