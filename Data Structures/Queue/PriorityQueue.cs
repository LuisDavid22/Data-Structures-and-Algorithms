using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class PriorityQueue
    {
        private int[] items;
        int front, rear = 0;
        int count;

        public PriorityQueue(int size = 100)
        {
            items = new int[size];
        }

        public void enqueue(int item)
        {
            if (isFull())
                return;

            if (isEmpty())
            {
                items[rear++] = item;
                return;
            }

            for (int i = rear -1; i >= front; i--)
            {
                if(items[i] > item)
                {
                    items[i + 1] = items[i];

                    if(i == front)
                    {
                        items[i] = item;
                        break;
                    }
                }
                else
                {
                    items[i + 1] = item;
                    break;
                }
                    

            }

            rear++;
        }
        public void add(int item)
        {
            int i;
            for ( i = count -1; i >= 0; i--)
            {
                if (items[i] > item)
                    items[i + 1] = items[i];
                else
                    break;
            }
            items[i + 1] = item;
            count++;
        }
        public int dequeue()
        {
            if (isEmpty())
                return -1;

            return items[front++];
        }
        public int peek()
        {
            if (isEmpty())
                return -1;

            return items[front];
        }
        public bool isFull()
        {
            return rear == items.Length;
        }
        public bool isEmpty()
        {
            return (front == 0 && rear == 0) || front > rear;
        }
        public override string ToString()
        {
            int[] result = new int[rear - front];
            System.Array.Copy(items, front, result, 0, rear - front);

            return $"[{string.Join(",", result)}]";
        }
    }
}
