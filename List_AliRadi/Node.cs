using System;
using System.Collections.Generic;
using System.Text;

namespace List_AliRadi
{
    class Node
    {
        public object Element { get; private set; }
        public Node Next { get; set; }

        public Node(object element, Node next)
        {
            Element = element;
            Next = next;
        }
    }
}
