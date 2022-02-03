using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int Data { get; set; }
        // public Node Left { get; set; }
        // public Node Right { get; set; }
        // Properties can not be passed by ref
        public Node left;
        public Node right;
        public Node(int data)
        {
            Data = data;
            left = right = null;
        }
        public void Insert(int value)
        {
            if(value < this.Data)
            {
                InsertIntoSubtree(ref this.left, value);
                return;
            }

            InsertIntoSubtree(ref this.right, value);
        }

        private void InsertIntoSubtree(ref Node subtree, int value)
        {
            if(subtree == null)
            {
                subtree = new Node(value);
                return;
            }

            subtree.Insert(value);
        }
    }

}
