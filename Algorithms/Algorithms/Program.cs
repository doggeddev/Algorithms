using Algorithms.Helpers;
using Algorithms.SortingAlgorithms;
using Algorithms.SortingAlgorithms.Interfaces;
using System;

namespace Algorithms
{
    internal class Program
    {
        private static IRandomArray _array = new RandomFilledArray(10);

        private static void Main(string[] args)
        {
            BubbleSortTest();
            InsertionSortTest();
        }

        private static void BubbleSortTest()
        {
            Console.WriteLine("Bubble Sort Test:");

            int[] arr = _array.GetRandomIntegerArray();

            ISortAble bubbleSort = new BubbleSort();

            bubbleSort.StartTimer();

            int[] sorted = bubbleSort.Sort(arr);

            bubbleSort.StopTimer();

            bubbleSort.PrintArray(sorted);

            bubbleSort.PrintElapsedTime();

            bubbleSort.ResetTimer();
        }

        private static void InsertionSortTest()
        {
            Console.WriteLine("Insertion Sort Test:");

            int[] arr = _array.GetRandomIntegerArray();

            ISortAble insertionSort = new InsertionSort();

            insertionSort.StartTimer();

            int[] sorted = insertionSort.Sort(arr);

            insertionSort.StopTimer();

            insertionSort.PrintArray(sorted);

            insertionSort.PrintElapsedTime();

            insertionSort.ResetTimer();
        }
    }
}