using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectionControl
{
    public class CircularBuffer<T>
    {
        private T[] _buffer;
        private int _nextFree;
        private bool _isFull;

        public int nextFree
        {
            get { return _nextFree; }
        }

        public CircularBuffer(int size)
        {
            _buffer = new T[size];
            _nextFree = 0;
            _isFull = false;
        }

        public void Add(T element)
        {
            _buffer[nextFree] = element;
            _nextFree = (_nextFree + 1) % _buffer.Length;

            if (!_isFull && _nextFree == 0)
            {
                _isFull = true;
            }
        }

        public T[] ToArray()
        {
            if (_isFull)
            {
                return _buffer;
            }
            else
            {
                var temp = new T[_nextFree];
                for (int i = 0; i < _nextFree; i++)
                {
                    temp[i] = _buffer[i];
                }
                return temp;
            }
        }

        // Arguable method
        public T this[int index]
        {
            get
            {
                if (_isFull)
                    return _buffer[index];
                else
                {
                    if (index >= _nextFree)
                        return _buffer[_nextFree - 1];
                    else
                        return _buffer[index];
                }
            }
        }
    }
}
