using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    public class AVLTree
    {
        AVLNode Root;
        private class AVLNode
        {
            public int Value { get; set; }
            public AVLNode LeftChild { get; set; }
            public AVLNode RightChild { get; set; }
            public int height { get; set; }
        }

        public void insert2(int value)
        {
            if(Root == null)
            {
                var newNode = new AVLNode()
                {
                    Value = value
                };

                Root = newNode;
            }
            else
            {
                insert(value, Root);
            }
           
        }
        private void insert2(int value, AVLNode node)
        {
            
            if (value < node.Value)
            {
                if (node.LeftChild == null)
                    node.LeftChild = new AVLNode { Value = value };
                else
                    insert(value, node.LeftChild);
            }
            else
            {
                if (node.RightChild == null)
                    node.RightChild = new AVLNode { Value = value };
                else
                    insert(value, node.RightChild);
               
            }

        }

        public void insert(int value)
        {
            Root = insert(value,Root);
        }

        private AVLNode insert(int value, AVLNode root)
        {
            if (root == null)
                return new AVLNode()
                {
                    Value = value
                };

            if (value < root.Value)
                root.LeftChild = insert(value, root.LeftChild);
            else
                root.RightChild = insert(value, root.RightChild);

            root.height = Math.Max(height(root.LeftChild), height(root.RightChild)) + 1;

           root = balance(root);
               

            return root;
        }
        private AVLNode balance(AVLNode root)
        {
            if (isLeftHeavy(root))
            {
                Console.WriteLine($"{root.Value} is left heavy");

                if (balanceFactor(root.LeftChild) < 0)
                {
                    Console.WriteLine($"left rotation on {root.LeftChild.Value}");
                    root.LeftChild = leftRotate(root.LeftChild);
                }
                   
                Console.WriteLine($"right rotation on {root.Value}");
                root = rightRotate(root);

            }
            else if (isrightHeavy(root))
            {
                Console.WriteLine($"{root.Value} is right heavy");

                if (balanceFactor(root.RightChild) > 0)
                {
                    Console.WriteLine($"right rotation on {root.RightChild.Value}");
                    root.RightChild = rightRotate(root.RightChild);
                }
                    

                Console.WriteLine($"left rotation on {root.Value}");
                root = leftRotate(root);

            }

            return root;
        }
        private AVLNode leftRotate(AVLNode root)
        {
            var newRoot = root.RightChild;
            root.RightChild = null;

            if (newRoot.LeftChild != null)
            {
                if (newRoot.LeftChild.Value > root.Value)
                    root.RightChild = newRoot.LeftChild;
                else
                    root.LeftChild = newRoot.LeftChild;
            }

            newRoot.LeftChild = root;

            root.height = Math.Max(height(root.LeftChild), height(root.RightChild)) + 1;
            newRoot.height = Math.Max(height(newRoot.LeftChild), height(newRoot.RightChild)) + 1;
            

            return newRoot;
        }
        private AVLNode rightRotate(AVLNode root)
        {
            var newRoot = root.LeftChild;
            root.LeftChild = null;

            if(newRoot.RightChild != null)
            {
                if (newRoot.RightChild.Value > root.Value)
                    root.RightChild = newRoot.RightChild;
                else
                    root.LeftChild = newRoot.RightChild;
            }

            newRoot.RightChild = root;


            root.height = Math.Max(height(root.LeftChild), height(root.RightChild)) + 1;
            newRoot.height = Math.Max(height(newRoot.LeftChild), height(newRoot.RightChild)) + 1;
            

            return newRoot;
        }
        private bool isLeftHeavy(AVLNode node)
        {
            return balanceFactor(node) > 1;
        }
        private bool isrightHeavy(AVLNode node)
        {
            return balanceFactor(node) < -1;
        }
        private int balanceFactor(AVLNode node)
        {
            return node == null ? 0 : height(node.LeftChild) - height(node.RightChild);
        }
        private int height(AVLNode root)
        {
            return root == null ? -1 : root.height;
        }
    }
}
