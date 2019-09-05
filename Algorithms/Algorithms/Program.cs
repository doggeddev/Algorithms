using Algorithms.SortingAlgorithms;
using System;
using System.Linq;

namespace Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BubbleSortTest();
        }

        private static void BubbleSortTest()
        {
            int[] arr = { 90, 1, 68, 34, 100, 67, 13, 12, 11, 89, 1000, 20, 77, 43, 9 };

            IBubbleSort bubbleSort = new BubbleSort();

            int[] sorted = bubbleSort.Sort(arr);

            Console.WriteLine("Bubble Sort:");

            sorted.ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}