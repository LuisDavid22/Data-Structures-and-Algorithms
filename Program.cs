using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Data_Structures.Array numbers = new Data_Structures.Array(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.print();
            Console.WriteLine(numbers.indexOf(30));
        }
    }
}
