using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SmartArrays
{
    class SmartArray
    {
        private int _size;
        private int _last = -1;
        private int[] _array;
        public SmartArray(int size)
        {
            _array = new int[size];
            _size = _array.Length;
        }

        public int Length
        {
            get { return _last + 1; }
        }

        public void Add(int item)
        {
            if(_last == (_size - 1))
            {
                Array resized = Array.CreateInstance(typeof(int), _size * 2);
                Array.Copy(_array, resized, _size);
                _array = (int[])resized;
                _size = _array.Length;
            }
            _array[++_last] = item;
        }

        public void Remove(int index)
        {
            Array newArray = Array.CreateInstance(typeof(int), _size);
            if(index != 0)
            {
                Array.Copy(_array, newArray, index);
            }
            Array.Copy(_array, index + 1, newArray, index, Length - index - 1);
            _array = (int[])newArray;
            _last -= 1;
        }

        public int this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        private class SmartEnumerator : IEnumerator, IDisposable
        {
            private int _index = -1;
            private SmartArray _smarty;
            public SmartEnumerator(SmartArray smarty)
            {
                _smarty = smarty;
            }



            public object Current => _smarty[_index];

            public void Dispose()
            {
                ;
            }

            public bool MoveNext()
            {
                _index++;
                return _index < _smarty.Length;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new SmartEnumerator(this);
        }

    }
}
