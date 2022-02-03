using SingleList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Stack
    {
        private List list;
        public Stack()
        {
            list = new List();
        }
        public bool IsEmpty() { return list.IsEmpty(); }
        public void Display() { list.Display(); }

        public void Push(object obj) { list.InsertFront(obj); }
        public object Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty!");
            }
            return list.RemoveFront();
        }
    }
}
