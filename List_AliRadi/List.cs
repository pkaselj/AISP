using System;
using System.Collections.Generic;
using System.Text;

namespace List_AliRadi
{
    class List
    {
        private Node _head;
        private Node _tail;

        public List()
        {
            _head = _tail = null;
        }

        public bool isEmpty() => _head == null;

        public void InsertFront(object element)
        {
            if (isEmpty())
            {
                _head = _tail = new Node(element, null);
                return;
            }

            Node newNode = new Node(element, _head);
            _head = newNode;
        }

        public void InsertEnd(object element)
        {
            if (isEmpty())
            {
                _head = _tail = new Node(element, null);
                return;
            }

            _tail.Next = new Node(element, null);
            _tail = _tail.Next;
        }

        public void RemoveFront()
        {
            if(isEmpty())
            {
                throw new Exception("Cannot remove item from empty list");
            }

            Node toRemove = _head;
            _head = _head.Next;
            toRemove.Next = null;
        }

        public void RemoveEnd()
        {
            if (isEmpty())
            {
                throw new Exception("Cannot remove item from empty list");
            }

            Node nodeBeforeLast = _head;
            while(nodeBeforeLast.Next != _tail)
            {
                nodeBeforeLast = nodeBeforeLast.Next;
            }

            _tail = nodeBeforeLast;
            _tail.Next = null;
        }

        public void Display()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Element + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
