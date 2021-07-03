using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    public class Heap
    {
        public int[] heap = new int[50];
        public int size = 0;

        public void insert(int item)
        {
            heap[size++] = item;

            if(size > 1)
            {
                int counter = size - 1;
                while (true)
                {                 
                    int parentIndex = (int)Math.Floor((double)((counter - 1) / 2));

                    if(heap[counter] > heap[parentIndex])
                    {            
                        counter = bubbleUpAndDown(counter, parentIndex); ;
                    }
                    else
                    {
                        break;
                    }
                }
            }


        }
       public void remove()
        {
            if (heap[0] == 0)
                return;

            heap[0] = heap[size - 1];
            heap[--size] = 0;

            int counter = 0;
            while (true)
            {
                int leftChild = counter * 2 + 1; 
                int rightChild = counter * 2 + 2; 

                if(heap[counter] < heap[leftChild])
                {                  
                    counter = bubbleUpAndDown(counter, leftChild); ;
                    continue;
                }

                if (heap[counter] < heap[rightChild])
                {      
                    counter = bubbleUpAndDown(counter, rightChild); ;
                    continue;
                }

                break;
            }
            
        }

        public int[] heapify(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int leftChildIndex = i * 2 + 1;
                int rightChildIndex = i * 2 + 2;

                if (leftChildIndex >= array.Length && rightChildIndex >= array.Length)
                    break;

                if(rightChildIndex >= array.Length)
                {
                    if(array[leftChildIndex] > array[i])
                    {
                        swap(array, i, leftChildIndex);
                    }
                    continue;
                }

                var biggerChildIndex = getBiggerChild(array, leftChildIndex, rightChildIndex);

                if(array[biggerChildIndex] > array[i])
                {
                    swap(array, i, biggerChildIndex);
                }
            


            }

            return array;
        }
        private int getBiggerChild(int[] array,int leftChildIndex, int rightChildIndex)
        {
            int leftChild = array[leftChildIndex];
            int rightChild = array[rightChildIndex];

            return leftChild > rightChild ? leftChildIndex : rightChildIndex;
        }
        private void swap(int[] array, int item1 , int item2)
        {
            var temp = array[item1];
            array[item1] = array[item2];
            array[item2] = temp;
        }
        private int bubbleUpAndDown(int up, int down)
        {
            var temp = heap[up];
            heap[up] = heap[down];
            heap[down] = temp;

            return down;
        }
    }
}
