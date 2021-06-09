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
        public List<int> GetNodesAtKth(int k)
        {
            var list = new List<int>();
            GetNodesAtKth(Root, k,list);

            return list;
        }
        private void GetNodesAtKth(Node node, int k, List<int> list)
        {
            if (node == null)
                return;

            if (k == 0)
            {
                list.Add(node.Value);
                return;
            }


            GetNodesAtKth(node.LeftChild, k - 1,list);
            GetNodesAtKth(node.RightChild, k - 1,list);
        }
        public int size()
        {
            return size(Root);
        }
        private int size(Node node)
        {
            if (node == null)
                return 0;

            return 1 + size(node.LeftChild) + size(node.RightChild);
        }
        public int countLeaves()
        {
            return countLeaves(Root);
        }
        private int countLeaves(Node node)
        {
            if (node == null)
                return 0;

            if (isLeaf(node))
                return 1;

            return countLeaves(node.LeftChild) + countLeaves(node.RightChild);
        }
        public int max()
        {
            return max(Root);
        }
        private int max(Node root)
        {
            if (isLeaf(root))
                return root.Value;

            var left = max(root.LeftChild);
            var right = max(root.RightChild);

            return Math.Max(Math.Max(left, right), root.Value);

        }
        public int min()
        {
            return min(Root);
        }
        private int min(Node root)
        {
            if (isLeaf(root))
                return root.Value;

            var left = min(root.LeftChild);
            var right = min(root.RightChild);

            return Math.Min(Math.Min(left, right), root.Value);
        }
        public bool contains(int value)
        {
            return contains(Root, value);
        }
        private bool contains(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.Value == value)
                return true;

            var left = contains(root.LeftChild,value);
            var right = contains(root.RightChild,value);

            return left || right;
        }
        private bool isLeaf(Node node)
        {
            return node.LeftChild == null && node.RightChild == null;
        }
        private bool isEmpty()
        {
            return Root == null;
        }
    }
}
