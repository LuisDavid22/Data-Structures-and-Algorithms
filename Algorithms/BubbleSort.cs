namespace DataStructuresAndAlgorithms
{
    public class BubbleSort
    {
        public static int[] Sort(int[] items)
        {

            bool isSorted;

            for (int i = 0; i < items.Length; i++)
            {
                isSorted = true;
                for (int j = 0; j < items.Length - i -1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        int temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;

                        isSorted = false;
                    }


                }
                if (isSorted)
                    break;

            }

            return items;
        }
    }
}
