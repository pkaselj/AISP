using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class HashTable
    {
        Node[] buckets;
        int length;
        public HashTable(int length)
        {
            this.length = length;
            buckets = new Node[length];
        }
        public void Display()
        {
            for (int bucket = 0; bucket < buckets.Length; bucket++)
            {
                Node current = buckets[bucket];
                Console.Write(bucket + ": ");
                while (current != null)
                {
                    Console.Write("[" + current.Name + "," + current.Value + "] ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
        private int Hash(string str)
        {
            int hashValue = 0;
            foreach (var c in str)
            {
                hashValue ^= c;
            }
            return hashValue % this.length;
        }

        public void Insert(string name, int value)
        {
            int hash = Hash(name);
            Node currentNode = buckets[hash];

            if(currentNode == null)
            {
                buckets[hash] = new Node(name, value, null);
                return;
            }

            while(currentNode.Next != null && currentNode.Name != name)
            {
                currentNode = currentNode.Next;
            }

            if(currentNode.Name == name)
            {
                currentNode.Value = value;
                return;
            }

            currentNode.Next = new Node(name, value, null);
        }

        public int Search(string name)
        {
            int hash = Hash(name);
            Node currentNode = buckets[hash];

            if (currentNode == null)
            {
                throw new Exception($"Node with name: {name} not found!");
            }

            while (currentNode.Next != null && currentNode.Name != name)
            {
                currentNode = currentNode.Next;
            }

            if (currentNode.Name == name)
            {
                return currentNode.Value;
            }

            throw new Exception($"Node with name: {name} not found!");
        }

        public void Delete(string name)
        {
            int bucket = Hash(name);
            Node current = buckets[bucket];
            Node previous = null;
            while (current != null)
            {
                if (current != null && current.Name == name)
                {
                    if(previous == null)
                    {
                        buckets[bucket] = current.Next;
                        return;
                    }
                    previous.Next = current.Next;
                    return;
                }

                previous = current;
                current = current.Next;
            }

            throw new Exception(name + " Not found.");
        }

    }
}
