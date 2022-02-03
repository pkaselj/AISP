using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList
{
    class BllList
    {
        private Node head;
        private int count;
        public object Count
        {
            get { return count; }
        }

        public BllList()
        {
            head = null;
            count = 0;
        }
        public bool IsEmpty()
        {
            if (count == 0) return true;
            return false;
        }

        public void Append(object element)
        {
            Node newNode = new Node(element, null, null);

            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
                count += 1;
                return;
            }

            Node last = head.Prev;

            last.Next = newNode;
            newNode.Prev = last;

            newNode.Next = head;
            head.Prev = newNode;

            count += 1;
        }

        public Node Find(object element)
        {
            if (IsEmpty())
            {
                return null;
            }

            Node current = head;
            do
            {
                if (current.Element == element)
                {
                    return current;
                }
                current = current.Next;
            } while (current != head);

            return null;
        }
        public void Remove(object element)
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot remove item from empty list!");
            }

            Node target = Find(element);
            if(target == null)
            {
                throw new Exception("Element not found!");
            }

            Node previous = target.Prev;
            Node next = target.Next;

            previous.Next = next;
            next.Prev = previous;

            target.Next = null;
            target.Prev = null;

            if(head == target)
            {
                head = next;
            }

            count -= 1;

        }

        public bool Search(object element) => Find(element) != null;

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("EMPTY LIST!");
                return;
            }

            Node current = head;
            do
            {
                Console.WriteLine(current.Element + " ");
                current = current.Next;
            } while (current != head);

            Console.WriteLine();
        }




    }
}
