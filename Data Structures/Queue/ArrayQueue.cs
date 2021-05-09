using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class ArrayQueue
    {
        int[] items;
        int F, R = 0;

        public ArrayQueue(int size = 100)
        {
            items = new int[size];
        }
        public void enqueue(int item)
        {
            if (isFull())
                return;

            items[R++] = item;


        }

        public int dequeue()
        {
            if (isEmpty())
                return -1;

            return items[F++];

        }

        public int peek()
        {
            if (isEmpty())
                return -1;

            return items[F];

        }

        public bool isEmpty()
        {
            return (F == 0 && R == 0) || F > R;
        }
        public bool  isFull()
        {
            return R == items.Length;
        }
        public override string ToString()
        {
            int[] result = new int[R - F];
            System.Array.Copy(items, F, result, 0,R-F);

            return $"[{string.Join(",",result)}]";
        }
    }
}
