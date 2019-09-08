using Algorithms.SearchingAlgorithms.BaseClasses;

namespace Algorithms.SearchingAlgorithms.Algorithms
{
    internal class BinarySearch : SearchBase
    {
        //assumes a sorted array is passed in
        public override bool Search(int[] arr, int elementToFind)
        {
            return StartBinarySearch(arr, elementToFind, 0, arr.Length - 1);
        }

        private bool StartBinarySearch(int[] arr, int elementToFind, int first, int last)
        {
            if (first > last)
            {
                return false;
            }
            else
            {
                int middle = (first + last) / 2;

                if (elementToFind == arr[middle])
                {
                    return true;
                }
                else if (elementToFind < arr[middle])
                {
                    return StartBinarySearch(arr, elementToFind, first, middle - 1);
                }
                else
                {
                    return StartBinarySearch(arr, elementToFind, middle + 1, last);
                }
            }
        }
    }
}