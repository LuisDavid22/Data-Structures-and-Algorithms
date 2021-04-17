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
                System.Array.Resize(ref array, count * 2);
            }
            array[count++] = element;

        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            for (int i = index ; i < count; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }
        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public int indexOf(int element)
        {
            for (int i = 0; i <= count - 1; i++)
            {
                if (array[i] == element)
                    return i;
            }

            return -1;
        }
    }
}
