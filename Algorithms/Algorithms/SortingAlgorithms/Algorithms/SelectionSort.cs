namespace Algorithms.SortingAlgorithms
{
    public class SelectionSort : SortBase
    {
        public override int[] Sort(int[] arr)
        {
            return SortArray(arr);
        }

        private int[] SortArray(int[] arr)
        {
            int i, j, min;

            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;

                        int temp = arr[i];
                        arr[i] = arr[min];
                        arr[min] = temp;
                    }
                }
            }

            return arr;
        }
    }
}