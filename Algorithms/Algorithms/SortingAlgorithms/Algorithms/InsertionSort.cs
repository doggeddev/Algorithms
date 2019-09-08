namespace Algorithms.SortingAlgorithms
{
    internal class InsertionSort : SortBase
    {
        public override int[] Sort(int[] arr)
        {
            return SortArray(arr);
        }

        private int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}