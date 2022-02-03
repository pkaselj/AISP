using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class Node
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(string name, int value, Node next)
        {
            Name = name;
            Value = value;
            Next = next;
        }

    }
}
