using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SingleList_Generic
{
    public class GenericList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public void AddFront(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                tail = head = node;
            else
                tail = tail.Next = node;
        }

        // ...
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
