using DataStructuresAndAlgorithms.Data_Structures;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //reverse(queue);
            //testStack();
            //testArray();
            //testLinkedList();

            //testArrayQueue();
            //testStackQueue();
            //testPriorityQueue();
            //testQueueReverser();

            //string text = "a green apple";
            //CharFinder finder = new CharFinder();
            //Console.WriteLine(finder.firstRepeatedCharacter(text));
            //testHashTable();
            testTree();
        }
        public static void testTree()
        {
            Tree tree = new Tree();
            //Tree tree2 = new Tree();

            tree.insert(7);
            tree.insert(4);
            tree.insert(9);
            tree.insert(1);
            tree.insert(6);
            tree.insert(8);
            tree.insert(10);


            //tree2.insert(7);
            //tree2.insert(4);
            //tree2.insert(9);
            //tree2.insert(1);
            //tree2.insert(6);
            //tree2.insert(8);
            //tree2.insert(10);
            //tree2.insert(20);

            // Console.WriteLine(tree.equals(tree2));
            //Console.WriteLine(tree.isValid());
            //var list = tree.GetNodesAtKth(2);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //tree.traverseInOrder();
            //Console.WriteLine("\n");
            //tree.traversePostOrder();
            Console.WriteLine(tree.contains(8));
        }
        public static void testHashTable()
        {
            HashTable hashtable = new HashTable();

            hashtable.put(1, "a");
            hashtable.put(1, "d");
            hashtable.put(2, "b");
            hashtable.put(11, "c");
        

            Console.WriteLine(hashtable.get(2));
            hashtable.remove(11);
        }
        public static void testQueueReverser()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            QueueReverser.reverse(5, queue);



        }
        public static void testPriorityQueue()
        {
            PriorityQueue queue = new PriorityQueue();

            //queue.enqueue(1);
            //queue.enqueue(3);
            //queue.enqueue(5);
            //queue.enqueue(2);
            //queue.enqueue(4);

                queue.add(5);
                queue.add(3);

            Console.WriteLine(queue.ToString());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.peek());
            Console.WriteLine(queue.ToString());
        }
        public static void testStackQueue()
        {
            StackQueue queue = new StackQueue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);

            var peek = queue.peek();

            Console.WriteLine(peek);
            Console.WriteLine(queue.ToString());
        }
        public static void testArrayQueue()
        {
            ArrayQueue queue = new ArrayQueue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);

            //queue.dequeue();
            //queue.dequeue();
            //queue.dequeue();

            //for (int i = 0; i < 120; i++)
            //{
            //    queue.enqueue(5);
            //}

            Console.WriteLine(queue.ToString());

            Console.WriteLine(queue.isEmpty());
            Console.WriteLine(queue.isFull());

        }
        public static void reverse(Queue<int> queue)
        {
            Console.WriteLine(string.Join(",", queue.ToArray()));

            Stack<int> stack = new Stack<int>();

            while(queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while(stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            Console.WriteLine(string.Join(",", queue.ToArray()));
        }
        private static void testStack()
        {
            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

      

            while (!stack.isEmpty())
            {
                var last = stack.pop();
                Console.WriteLine(last);
            }


            //string str = "abcde";
            //StringReverser reverser = new StringReverser();

            ////Console.WriteLine(reverser.reverse(null));

            //var result = reverser.isBalanced("((klk))");
            //Console.WriteLine(result);
        }
        private static void testLinkedList()
        {
            LinkedList numbers = new LinkedList();

            numbers.addLast(1);
            numbers.addLast(2);
            numbers.addLast(3);
            numbers.addLast(4);
            numbers.addLast(5);

            numbers.addLast(10);

            //numbers.deleteFirst();

            numbers.deleteLast();

            Console.WriteLine(numbers.contains(4));


            Console.WriteLine(numbers.indexOf(5));

            Console.WriteLine(numbers.Size());


            //Console.WriteLine(string.Join(',', numbers.toArray()));
            //numbers.revert2();
            Console.WriteLine(string.Join(',', numbers.toArray()));

            Console.WriteLine(numbers.getKthFromTheEnd(6));

            numbers.printMiddle();

            var list = Data_Structures.LinkedList.createWithLoop();

            Console.WriteLine(list.hasLoop());

        }
        private static void testArray()
        {
            Data_Structures.Array numbers = new Data_Structures.Array(3);
            numbers.insert(10);
            numbers.insert(40);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(150);
            numbers.insert(756);
            numbers.insert(350);
            numbers.insert(123);

            //var testArray = new Data_Structures.Array(5);
            //testArray.insert(1);
            //testArray.insert(2);
            //testArray.insert(7);
            //testArray.insert(150);
            //testArray.insert(350);

            //var test = numbers.intersect(testArray);
            //test.print();
            //var test = numbers.reverse();
            //numbers.removeAt(3);
            numbers.insertAt(500, 5);
            numbers.print();

            //Console.WriteLine(string.Join(",",test));
            //Console.WriteLine(numbers.indexOf(30));
        }
    }   
}
