using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class StackQueue
    {
        Stack<int> input = new Stack<int>();
        Stack<int> output = new Stack<int>();


        public void enqueue(int item)
        {
            input.Push(item);
        }
        public int dequeue()
        {
            if (isEmpty())
                return -1;

            while(input.Count > 0)
            {
                output.Push(input.Pop());
            }

            var result = output.Pop();

            while(output.Count > 0)
            {
                input.Push(output.Pop());
            }

            return result;
        }
        public int peek()
        {
            if (isEmpty())
                return -1;

            while (input.Count > 0)
            {
                output.Push(input.Pop());
            }

            var result = output.Peek();

            while (output.Count > 0)
            {
                input.Push(output.Pop());
            }

            return result;
        }

        public bool isEmpty()
        {
            return input.Count == 0;
        }

        public override string ToString()
        {

            return $"[{string.Join(",", input.ToArray())}]";
        }
    }
}
