namespace Algorithms.SortingAlgorithms
{
    public class BubbleSort : SortBase
    {
        public override int[] Sort(int[] arr)
        {
            return SortArray(arr);
        }

        private int[] SortArray(int[] arr)
        {
            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr;
        }
    }
}