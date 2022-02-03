using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        private Node root;
        public Tree()
        {
            root = null;
        }
        public void Insert(int value)
        {
            if (root == null)
                root = new Node(value);
            else
                root.Insert(value);
        }
        public bool Search(int value)
        {
            Node node = Search(root, value);
            if (node != null)
                return true;
            else
                return false;
        }
        private Node Search(Node current, int value)
        {
            if(current == null)
            {
                return null;
            }
            else if(value == current.Data)
            {
                return current;
            }
            else if(value < current.Data)
            {
                return Search(current.left, value);
            }

            return Search(current.right, value);
        }

        public void Delete(int value)
        {
            Delete(ref root, value);
        }
        private void Delete(ref Node current, int value)
        {
            if(current == null)
            {
                return;
            }
            else if (current.Data == value)
            {
                if(current.left == null && current.right == null)
                {
                    current = null;
                    return;
                }
                else if (current.left != null && current.right == null)
                {
                    current = current.left;
                    return;
                }
                else if (current.left == null && current.right != null)
                {
                    current = current.right;
                    return;
                }

                int successor = DeleteSuccessor(ref current.right);
                current.Data = successor;
                return;
            }
            else if(value < current.Data)
            {
                Delete(ref current.left, value);
                return;
            }
       
            Delete(ref current.right, value);
        }
        private int DeleteSuccessor(ref Node current)
        {
            int successor;
            if (current.left == null)
            {
                successor = current.Data;
                current = current.right;
                return successor;
            }
            return DeleteSuccessor(ref current.left);
        }

        public enum TraversalType { PreOrder, InOrder, PostOrder }

        public void Traverse(TraversalType traverse)
        {
            switch (traverse)
            {
                case TraversalType.PreOrder:
                    TraversePreorder(root);
                    break;
                case TraversalType.InOrder:
                    TraverseInorder(root);
                    break;
                case TraversalType.PostOrder:
                    TraversePostorder(root);
                    break;
                default:
                    Console.WriteLine("What a #@$@#@!");
                    break;
            }
        }
        private void TraversePreorder(Node node)
        {
            if(node != null)
            {
                TraversePreorder(node.left);
                TraversePreorder(node.right);
                Console.Write($"{node.Data} ");
            }
        }
        private void TraverseInorder(Node node)
        {
            if (node != null)
            {
                TraverseInorder(node.left);
                Console.Write($"{node.Data} ");
                TraverseInorder(node.right);
            }
        }
        private void TraversePostorder(Node node)
        {
            if (node != null)
            {
                Console.Write($"{node.Data} ");
                TraversePostorder(node.left);
                TraversePostorder(node.right);
            }
        }
    }

}
