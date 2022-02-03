using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSingleList
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
