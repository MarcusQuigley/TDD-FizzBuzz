using System;

namespace FizzBuzz
{
    public class MyStack<T>
    {
        T[] _array;
        int _index = -1;
        
        public MyStack()
        {
            _array = new T[2];
        }

        int StackCapacity => _array.Length;

        public void Push(T value)
        {
            if (value == null || value.GetType() != typeof(T))
                throw new ArgumentException("value must be of type string and not null.");
            CheckResize();
            _array[++_index] = value;
        }

        public T Pop()
        {
            if (_index == -1)
                return default(T);
            else
            {
                var result = _array[_index--];
                return result;
            }
        }
 
        private void CheckResize()
        {
            if (_index % StackCapacity == 0)
            {
                Array.Resize(ref _array, StackCapacity * 2);
            }
        }
    }
}
