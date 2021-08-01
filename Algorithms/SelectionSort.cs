namespace DataStructuresAndAlgorithms
{
    public static class SelectionSort
    {
        public static void sort(int[] items)
        {
            
            for (int i = 0; i < items.Length; i++)
            {
                int minValue = items[i];
                int indexToSwapFor = i;
                for (int j = i; j < items.Length; j++)
                {
                    if (items[j] < minValue)
                    {
                        minValue = items[j];
                        indexToSwapFor = j;
                    }
                        
                }
                var temp = items[i];
                items[i] = minValue;
                items[indexToSwapFor] = temp;
            }
        }
    }
}
