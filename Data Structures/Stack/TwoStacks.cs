using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class TwoStacks
    {
        private int[] elements = new int[100];
        private int count1 = 1;
        private int count2;

        public void push1(int item)
        {
            if (isFull1())
            {
                System.Array.Resize(ref elements, elements.Length * 2);
            }

            elements[count1] = item;

            count1 += 2;
        }
        public void push2(int item)
        {
            if (isFull2())
            {
                System.Array.Resize(ref elements, elements.Length * 2);
            }

            elements[count2] = item;

            count2 += 2;
        }

        public bool isFull1()
        {
            return count1 == elements.Length - 1;
        }
        public bool isFull2()
        {
            return count2 == elements.Length;
        }
    }
}
