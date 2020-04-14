using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] data;
        private int size;

        public Stack(int size)
        {
            data = new T[size];
        }
        
        public Stack() : this(1000)
        {
        }

        public  void Push(T item)
        {
            if (size == data.Length)
            {
                throw new InvalidOperationException("no more space in the stack");
            }

            data[size++] = item;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("no item in the stack");
            }

            return data[--size];
        }

        public T Peak()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("no item left in the stack");
            }

            return data[size - 1];
        }

        public int Size()
        {
            return size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
