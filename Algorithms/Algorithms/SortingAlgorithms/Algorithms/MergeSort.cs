using System;

namespace Algorithms.SortingAlgorithms.Algorithms
{
    public class MergeSort : SortBase
    {
        public override int[] Sort(int[] arr)
        {
            MergeAndSort(ref arr, 0, arr.Length - 1);
            return arr;
        }

        private void MergeAndSort(ref int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeAndSort(ref arr, left, middle);
                MergeAndSort(ref arr, middle + 1, right);

                Merge(ref arr, left, middle, right);
            }
        }

        private void Merge(ref int[] arr, int left, int middle, int right)
        {
            int[] leftArr = new int[middle - left + 1];
            int[] rightArr = new int[right - middle];

            Array.Copy(arr, left, leftArr, 0, middle - left + 1);
            Array.Copy(arr, middle + 1, rightArr, 0, right - middle);

            int i = 0;
            int j = 0;

            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArr.Length)
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                else if (j == rightArr.Length)
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
            }
        }
    }
}