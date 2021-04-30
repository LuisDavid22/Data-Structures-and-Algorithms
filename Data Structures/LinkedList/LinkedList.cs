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

        public void revert2()
        {
            var previous = first;
            var current = first.next;
            
            while(current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
        }

        public int getKthFromTheEnd(int k)
        {

            if (isEmpty())
                return 0;

            if (k <= 0)
                return 0;

            if (k > size)
                return 0;

            var pointer1 = first;
            var pointer2 = first;

            for (int i = 1; i <= k - 1; i++)
            {
                pointer2 = pointer2.next;
            }

            while(pointer2.next != null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
            }

            return pointer1.value;
        }

        public void printMiddle()
        {
            var a = first;
            var b = first;

           while(b != last && b.next != last)
            {
                b = b.next.next;
                a = a.next;
            }

            if (b == last)
                Console.WriteLine(a.value);
            else
            {
                Console.WriteLine($"{a.value}, {a.next.value}");
            }
        }

        public bool hasLoop()
        {
            var slow = first;
            var fast = first;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }

            return false;
        }

        public static LinkedList createWithLoop()
        {
            var list = new LinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            list.addLast(40);
            list.addLast(50);

            // Get a reference to 30
            var node = list.first;

            list.addLast(60);
            list.addLast(70);


            // Create the loop
            list.last.next = node;

            return list;
        }
    }
}
