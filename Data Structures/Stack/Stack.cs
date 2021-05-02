using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class Stack
    {
        private int[] elements = new int[100];
        private int count;

        public void push(int item)
        {
            if(count == elements.Length)
            {
                System.Array.Resize(ref elements, count * 2);
            }

            elements[count++] = item;
        }

        public int pop()
        {
            if (isEmpty())
                throw new ArgumentOutOfRangeException();

            var last = elements[--count];
            return last;
        }
        public int peek()
        {
            if (isEmpty())
                throw new ArgumentOutOfRangeException();

            var last = elements[count -1];
            return last;
        }

        public bool isEmpty()
        {
            return count == 0;
        }
    }
}
