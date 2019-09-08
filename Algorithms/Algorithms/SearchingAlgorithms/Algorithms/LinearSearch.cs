using Algorithms.SearchingAlgorithms.BaseClasses;

namespace Algorithms.SearchingAlgorithms.Algorithms
{
    internal class LinearSearch : SearchBase
    {
        public override bool Search(int[] arr, int elementToFind)
        {
            return StartLinearSearch(arr, elementToFind);
        }

        private bool StartLinearSearch(int[] arr, int elementToFind)
        {
            int i = 0;
            int arrLength = arr.Length;

            while (i < arrLength)
            {
                if (arr[i] == elementToFind)
                {
                    return true;
                }

                i++;
            }

            return false;
        }
    }
}