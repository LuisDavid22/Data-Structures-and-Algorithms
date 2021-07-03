using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class MaxHeap
    {
            public static void heapify(int[] array)
            {
                var lastParentIndex = array.Length / 2 - 1;
            for (int i = 0; i < array.Length; i++)
                    heapify(array, i);
            }

            private static void heapify(int[] array, int index)
            {
                var largerIndex = index;

                var leftIndex = index * 2 + 1;
                if (leftIndex < array.Length &&
                    array[leftIndex] > array[largerIndex])
                    largerIndex = leftIndex;

                var rightIndex = index * 2 + 2;
                if (rightIndex < array.Length &&
                  array[rightIndex] > array[largerIndex])
                    largerIndex = rightIndex;

                if (index == largerIndex)
                    return;

                swap(array, index, largerIndex);
                heapify(array, largerIndex);
            }

            private static void swap(int[] array, int first, int second)
            {
                var temp = array[first];
                array[first] = array[second];
                array[second] = temp;
            }
        }
}
