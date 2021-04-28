using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class LinkedList
    {
        private class Node
        {
            public int value { get; set; }
            public Node next { get; set; }
        }

        private Node first { get; set; }
        private Node last { get; set; }
        private int size { get; set; }


       public void addFirst(int item)
        {
            if(isEmpty())
                first = last = new Node { value = item };
            else
            {
                first = new Node { value = item, next = first };
            }

            size++;        
        }

        public void addLast(int item)
        {
            if (isEmpty())
                addFirst(item);
            else
            {
                var newLast = new Node { value = item };
                last.next = newLast;
                last = newLast;
                size++;
            }
           
         

            //Node previousLastNode = new Node();

            //if(first.next == null)
            //{
            //    previousLastNode = first;
            //}
            //else
            //{
            //    previousLastNode = first.next;
            //}

            //while(previousLastNode.next != null)
            //{
            //    previousLastNode = previousLastNode.next;
            //}

            //previousLastNode.next = last;
        }
        public void deleteFirst()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            if(first == last)
                first = last = null;
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }

            size--;
            //var firstNode = first;
            //first = firstNode.next;
            //firstNode.next = null;
        
        }
        public void deleteLast()
        {
            if (isEmpty())
                throw new InvalidOperationException();


            if (first.next == null)
                first = last = null;
            else{
                var previousLastNode = getPrevious(last);

                previousLastNode.next = null;
                last = previousLastNode;
            }

         
            size--;
        }
        private Node getPrevious(Node node)
        {
            Node previousLastNode = first;

            while (previousLastNode != null)
            {
                if (previousLastNode.next == node)
                    return previousLastNode;

                previousLastNode = previousLastNode.next;
            }

            return null;
        }
        public bool contains(int value)
        {
            return indexOf(value) != -1;

            //return false;
        }
        public int indexOf(int item)
        {
            Node node = first;
            int counter = 0;

            while (node != null)
            {
                if (node.value == item)
                    return counter;

                node = node.next;
                counter++;
            }

            return -1;
        }
        public int Size()
        {
            return size;
        }
        public int[] toArray()
        {
            int[] array = new int[size];

            var current = first;
            int index = 0;
            while(current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }

            return array;
        }
        private bool isEmpty()
        {
            return first == null;
        }

        public void revert()
        {
            var current = last;
            Node Previous;

            for (int i = 0; i < size -1; i++)
            {
                Previous = getPrevious(current);

                Previous.next = null;
                
                current.next = Previous;

                current = current.next;
            }

            first = last;

            last = current;
        }
    }
}
