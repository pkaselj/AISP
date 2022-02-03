using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleList
{
    public class List
    {
        private Node head;
        private Node tail;
        public List() { head = tail = null; }
        public bool IsEmpty() { return head == null; }
        //5. Implement the method InsertFront in the List class, which inserts a new Node
        //at the front of the list.
        public void InsertFront(object obj)
        {
            Node newNode = new Node(obj, head);
            head = newNode;

            if (tail == null)
            {
                tail = newNode;
            }
        }
        //6. Implement the method InsertEnd in the List class, which inserts a new Node
        //at the end of the list.
        public void InsertEnd(object obj)
        {
            Node newNode = new Node(obj, null);
            if (tail != null)
            {
                tail.Next = newNode;
            }
            tail = newNode;

            if (head == null)
            {
                head = newNode;
            }
        }
        //Lab 4: Lists
        //7. Implement the method RemoveFront in the List class, which removes the first
        //element in the list.
        public object RemoveFront()
        {
            if (head == null) throw new Exception("List is empty!");

            var removedNode = head;
            head = head.Next;

            return removedNode.Element;
        }
        //8. Implement the method RemoveEnd in the List class, which removes the last
        //element in the list.
        public object RemoveEnd()
        {
            if (tail == null) throw new Exception("List is empty!");

            var removedNode = tail;

            var nodeBeforeTail = head;
            while(nodeBeforeTail != null && nodeBeforeTail.Next != tail)
            {
                nodeBeforeTail = nodeBeforeTail.Next;
            }

            tail = nodeBeforeTail;
            nodeBeforeTail.Next = null;

            return removedNode.Element;
        }
        //9. Add the public method Display to the List class, as shown below:

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Element + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
