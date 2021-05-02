using DataStructuresAndAlgorithms.Data_Structures;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Data_Structures.TwoStacks stack = new Data_Structures.TwoStacks();

            stack.push1(1);
            stack.push1(2);
            stack.push1(3);
            stack.push1(4);
            stack.push1(5);


            stack.push2(10);
            stack.push2(20);
            stack.push2(30);
            stack.push2(40);
            stack.push2(50);
            //testStack();
            //testArray();
            //testLinkedList();
        }
        private static void testStack()
        {
            Data_Structures.Stack stack = new Data_Structures.Stack();
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
            Data_Structures.LinkedList numbers = new Data_Structures.LinkedList();

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
