using Algorithms.Helpers;
using Algorithms.SearchingAlgorithms.Algorithms;
using Algorithms.SearchingAlgorithms.BaseClasses;
using Algorithms.SortingAlgorithms;
using Algorithms.SortingAlgorithms.Algorithms;
using Algorithms.SortingAlgorithms.Interfaces;
using System;

namespace Algorithms
{
    internal class Program
    {
        private const int ARRAY_SIZE = 1000000;

        private static readonly IRandomArray _array = new RandomFilledArray(ARRAY_SIZE);

        private static readonly int[] _arr = _array.GetRandomIntegerArray();

        private static readonly bool _printArray = false;

        private static void Main(string[] args)
        {
            StartSortingTest();
            StartSearchingTest();
        }

        private static void StartSortingTest()
        {
            //DotNetArraySortTest(); //Added as a baseline test and to show why you don't write your own sort methods
            //BubbleSortTest();
            //InsertionSortTest();
            //SelectionSortTest();
            //QuickSortTest();
            //MergeSortTest();
        }

        private static void StartSearchingTest()
        {
            LinearSearchTest();
        }

        #region Search Algorithm Tests

        private static void LinearSearchTest()
        {
            bool found = false;

            int[] arr = new int[_arr.Length];

            Array.Copy(_arr, arr, _arr.Length);

            //replace a randomly selected value in the array
            Random rand = new Random();

            int i = rand.Next(arr.Length);

            int valueToFind = 12345;

            arr[i] = valueToFind;

            Console.WriteLine("Linear Search Test");

            ISearchable linearSearch = new LinearSearch();

            linearSearch.StartTimer();

            found = linearSearch.Search(arr, valueToFind);

            linearSearch.StopTimer();

            Console.WriteLine($"Found element: {found} ");

            if (_printArray)
            {
                linearSearch.PrintArray(arr);
            }

            linearSearch.PrintElapsedTime();

            linearSearch.ResetTimer();
        }

        #endregion Search Algorithm Tests

        #region Sorting Algorithm Tests

        private static void DotNetArraySortTest()
        {
            int[] arr = new int[_arr.Length];

            Array.Copy(_arr, arr, _arr.Length);

            Console.WriteLine("Array.Sort() Test");

            ISortAble dotNetArraySort = new DotNetSort();

            dotNetArraySort.StartTimer();

            int[] sorted = dotNetArraySort.Sort(arr);

            dotNetArraySort.StopTimer();

            if (_printArray)
            {
                dotNetArraySort.PrintArray(arr);
            }

            dotNetArraySort.PrintElapsedTime();

            dotNetArraySort.ResetTimer();
        }

        private static void MergeSortTest()
        {
            int[] arr = new int[_arr.Length];

            Array.Copy(_arr, arr, _arr.Length);

            Console.WriteLine("Merge Sort Test");

            ISortAble mergeSort = new MergeSort();

            mergeSort.StartTimer();

            int[] sorted = mergeSort.Sort(arr);

            mergeSort.StopTimer();

            if (_printArray)
            {
                mergeSort.PrintArray(arr);
            }

            mergeSort.PrintElapsedTime();

            mergeSort.ResetTimer();
        }

        private static void QuickSortTest()
        {
            Console.WriteLine("Quick Sort Test");

            int[] arr = new int[_arr.Length];

            Array.Copy(_arr, arr, _arr.Length);

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

            int[] arr = new int[_arr.Length];

            Array.Copy(_arr, arr, _arr.Length);

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

            int[] arr = new int[_arr.Length];

            Array.Copy(_arr, arr, _arr.Length);

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

            int[] arr = new int[_arr.Length];

            Array.Copy(_arr, arr, _arr.Length);

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

        #endregion Sorting Algorithm Tests
    }
}