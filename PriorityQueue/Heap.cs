using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    class Heap
    {
        private int _size;
        private int _last;
        private int[] _priorities;

        public Heap(int size)
        {
            this._size = size;
            _priorities = new int[size + 1];
            _last = 0;
        }

        public void Insert(int value)
        {
            if(_last == _size)
            {
                throw new Exception($"Could not insert value \"{value}\" into the heap. The heap is full.");
            }

            _priorities[++_last] = value;
            BubbleUp(_last);
        }

        public void BubbleUp(int i)
        {
            if (i == 1) return;
            int parent = i / 2;
            if (_priorities[i] > _priorities[parent])
            {
                Swap(i, parent);
                BubbleUp(parent);
            }
        }

        private void Swap(int i, int parent)
        {
            int temp = _priorities[i];
            _priorities[i] = _priorities[parent];
            _priorities[parent] = temp;
        }

        public int Retrieve()
        {
            if(_last == 0)
            {
                throw new Exception("Queue is empty");
            }

            int priority = _priorities[1];
            _priorities[1] = _priorities[_last--];

            BubbleDown(1);

            return priority;
        }

        public void BubbleDown(int i)
        {
            int child = 2 * i;

            if(child < _last && _priorities[_last] < _priorities[child + 1])
            {
                child++;
            }

            if (child <= _last && _priorities[i] < _priorities[child])
            {
                Swap(i, child);
                BubbleDown(child);
            }
        }

        public void Display()
        {
            for (int i = 1; i <= _last; i++)
                Console.Write(_priorities[i] + " ");
            Console.WriteLine();
        }
    }
}
