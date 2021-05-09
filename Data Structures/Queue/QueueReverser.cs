using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    static class QueueReverser
    {
        public static void reverse(int k, Queue<int> queue)
        {
            if (k > queue.Count || k < 1)
                return;

            Stack<int> toReverse = new Stack<int>();
            Queue<int> toKeepOrder = new Queue<int>();
            int count = 0;

            while(queue.Count > 0)
            {
                
                if(count < k)
                {
                    toReverse.Push(queue.Dequeue());
                    count++;
                    continue;
                }

                toKeepOrder.Enqueue(queue.Dequeue());
                count++;
            }

            while(toReverse.Count > 0)
            {
                queue.Enqueue(toReverse.Pop());
            }

            while(toKeepOrder.Count > 0)
            {
                queue.Enqueue(toKeepOrder.Dequeue());
            }
        }
    }
}
