using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
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
