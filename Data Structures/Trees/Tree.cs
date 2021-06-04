using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    public class Tree
    {
        Node Root;
        private class Node
        {
            public int Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
        }

        public void insert(int value)
        {
            var node = new Node()
            {
                Value = value
            };


            if (isEmpty())
            {
                Root = node;
                return;
            }

            var current = Root;

            while (true)
            {
                if (value < current.Value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                        break;
                    }
                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                        break;
                    }
                    current = current.RightChild;
                }
            }

        }

        //}
        //public void insert(int value)
        //{
        //    if (isEmpty())
        //    {
        //        Root = new Node()
        //        {
        //            Value = value
        //        };
        //        return;
        //    }

        //    var current = Root;

        //    while(true)
        //    {
        //        if(value > current.Value)
        //        {
        //            current = current.RightChild;
        //        }
        //        else
        //        {
        //            current = current.LeftChild;
        //        }

        //        if(current == null)
        //        {
        //            current = new Node()
        //            {
        //                Value = value
        //            };

        //            break;
        //        }

        //    }



        //}

        public bool find(int value)
        {
            if (isEmpty())
                return false;

            var current = Root;

            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }

                if (value > current.Value)
                    current = current.RightChild;
                else
                    current = current.LeftChild;

            }

            return false;
        }
        public void traverseInOrder()
        {
            traverserInOrder(Root);
        }
        private void traverserInOrder(Node root)
        {
            if (root == null)
                return;

            traverserInOrder(root.LeftChild);
            Console.WriteLine(root.Value);
            traverserInOrder(root.RightChild);


        }

        public void traversePostOrder()
        {
            traversePostOrder(Root);
        }
        private void traversePostOrder(Node root)
        {
            if (root == null)
                return;

            traversePostOrder(root.LeftChild);
            traversePostOrder(root.RightChild);
            Console.WriteLine(root.Value);



        }
        public bool equals(Tree tree)
        {
            if (tree == null)
                return false; 

            return equals(Root, tree.Root);

        }
        private bool equals(Node node1, Node node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1 == null || node2 == null)
                return false;

            var root = node1.Value == node2.Value;
            var left = equals(node1.LeftChild, node2.LeftChild);
            var right = equals(node1.RightChild, node2.RightChild);

            if ((root && left && right))
                return true;

            return false;
        }
        public bool isValid()
        {
            swapRoot();
           return isValid(Root, int.MinValue, int.MaxValue);
        }
        private bool isValid(Node node, int leftLimit, int rightLimit)
        {
            if (node == null)
                return true;

            var root = node.Value >= leftLimit && node.Value <= rightLimit;
            var left = isValid(node.LeftChild, leftLimit, node.Value);
            var right = isValid(node.RightChild, node.Value, rightLimit);

            if ((root && left && right))
                return true;

            return false;
        }
        private void swapRoot()
        {
            var leftTemp = Root.LeftChild;

            Root.LeftChild = Root.RightChild;

            Root.RightChild = leftTemp;
        }
        private bool isEmpty()
        {
            return Root == null;
        }
    }
}
