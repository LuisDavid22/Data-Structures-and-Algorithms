using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class Array
    {
        private int[] array;
        int count = 0;
        public Array(int size)
        {
            array = new int[size];
        }

        public void insert(int element)
        {
            if(count >= array.Length)
            {
                System.Array.Resize(ref array, array.Length + 1);
            }
            array[count] = element;
            count++;
        }

        public void removeAt(int index)
        {
            if (index >= array.Length)
                return;

            //if (index == array.Length - 1)
            //{
            //    array[index] = 0;
            //}
            //else
            //{
            //    for (int i = index - 1; i < array.Length -1; i++)
            //    {
            //        array[i] = array[i + 1];
            //    }
            //}

            array = array.Where((s, i) => i != index).ToArray();
              
        }
        public void print()
        {
            Console.WriteLine(string.Join("\n", array));
        }

        public int indexOf(int element)
        {
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] == element)
                    return i;
            }

            return -1;
        }
    }
}
