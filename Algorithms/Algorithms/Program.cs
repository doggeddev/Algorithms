using Algorithms.Helpers;
using Algorithms.SortingAlgorithms;
using Algorithms.SortingAlgorithms.Interfaces;
using System;

namespace Algorithms
{
    internal class Program
    {
        private static IRandomArray _array = new RandomFilledArray(100000);

        private static bool _printArray = false;

        private static void Main(string[] args)
        {
            BubbleSortTest();
            InsertionSortTest();
            SelectionSortTest();
            QuickSortTest();
        }

        private static void QuickSortTest()
        {
            Console.WriteLine("Quick Sort Test");

            int[] arr = _array.GetRandomIntegerArray();

            ISortAble quickSort = new QuickSort();

            quickSort.StartTimer();

            int[] sorted = quickSort.Sort(arr);

            quickSort.StopTimer();

            if (_printArray)
            {
                quickSort.PrintArray(arr);
            }

            quickSort.PrintElapsedTime();

            quickSort.ResetTimer();
        }

        private static void SelectionSortTest()
        {
            Console.WriteLine("Selection Sort Test");

            int[] arr = _array.GetRandomIntegerArray();

            ISortAble selectionSort = new SelectionSort();

            selectionSort.StartTimer();

            int[] sorted = selectionSort.Sort(arr);

            selectionSort.StopTimer();

            if (_printArray)
            {
                selectionSort.PrintArray(arr);
            }

            selectionSort.PrintElapsedTime();

            selectionSort.ResetTimer();
        }

        private static void BubbleSortTest()
        {
            Console.WriteLine("Bubble Sort Test:");

            int[] arr = _array.GetRandomIntegerArray();

            ISortAble bubbleSort = new BubbleSort();

            bubbleSort.StartTimer();

            int[] sorted = bubbleSort.Sort(arr);

            bubbleSort.StopTimer();

            if (_printArray)
            {
                bubbleSort.PrintArray(sorted);
            }

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

            if (_printArray)
            {
                insertionSort.PrintArray(sorted);
            }

            insertionSort.PrintElapsedTime();

            insertionSort.ResetTimer();
        }
    }
}