namespace Algorithms.SortingAlgorithms
{
    internal class QuickSort : SortBase
    {
        public override int[] Sort(int[] arr)
        {
            SortArray(ref arr, 0, arr.Length - 1);
            return arr;
        }

        private void SortArray(ref int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(ref arr, start, end);

                SortArray(ref arr, start, i - 1);
                SortArray(ref arr, i + 1, end);
            }
        }

        private int Partition(ref int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }
}