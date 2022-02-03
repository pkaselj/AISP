using SingleList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private List list;
        public Queue()
        {
            list = new List();
        }
        public bool IsEmpty() { return list.IsEmpty(); }
        public void Display() { list.Display(); }

        public void Enqueue(object obj) { list.InsertEnd(obj); }
        public object Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty!");
            }
            return list.RemoveFront();
        }
    }
}
