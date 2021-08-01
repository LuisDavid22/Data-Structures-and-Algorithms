using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
   public static class InsertionSort 
    {
        public static void sort(int[] items)
        {
            for (int i = 1; i < items.Length; i++)
            {
                var current = items[i];
                int indexToInsert = i;
                for (int j = i-1; j >= 0; j--)
                {
                    if (items[j] > current)
                    {
                        items[j + 1] = items[j];
                        indexToInsert = j;
                    }              
                    else
                        break;       
                }

                items[indexToInsert] = current;
            }
        }
    }
}
