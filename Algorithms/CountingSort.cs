using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
   public class CountingSort
    {
        public static void sort(int[] array)
        {
            int[] counts = new int[getBiggerNumber(array) + 1];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i]]++; 
            }

            int arraySize = 0;

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    for (int j = 0; j < counts[i]; j++)
                    {
                        array[arraySize++] = i;
                    }
                }
                    
            }

        }

        private static int getBiggerNumber(int[] array)
        {
            int maxNumber = 0;

            foreach (var item in array)
            {
                if (item > maxNumber)
                    maxNumber = item;
            }

            return maxNumber;
        }
    }
}
