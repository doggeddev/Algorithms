using Algorithms.Helpers;
using Algorithms.SortingAlgorithms;
using System;
using System.Diagnostics;
using System.Linq;

namespace Algorithms
{
    internal class Program
    {
        private static IRandomArray _array = new RandomFilledArray(65000);

        private static void Main(string[] args)
        {
            BubbleSortTest();
        }

        private static void BubbleSortTest()
        {
            Stopwatch timer = new Stopwatch();

            int[] arr = _array.GetRandomIntegerArray();

            IBubbleSort bubbleSort = new BubbleSort();

            timer.Start();

            int[] sorted = bubbleSort.Sort(arr);

            timer.Stop();

            Console.WriteLine("Bubble Sort:");

            //sorted.ToList().ForEach(n => Console.Write($"{n},"));
            Console.WriteLine($"Time Elapsed: {timer.ElapsedMilliseconds} ms");

            timer.Reset();

            //pass sorted array to alogrithm, expecting shorter time to process.
            timer.Start();
            bubbleSort.Sort(arr);
            timer.Stop();

            Console.WriteLine("Bubble Sort(pre-sorted):");
            //sorted.ToList().ForEach(n => Console.Write($"{n},"));
            Console.WriteLine($"Time Elapsed: {timer.ElapsedMilliseconds} ms");
            timer.Reset();
        }
    }
}