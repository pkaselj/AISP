using System;
using System.Collections.Generic;
using System.Text;

namespace SingleList_Generic
{
    class Node<T>
    {
        public T Data = default(T);
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
