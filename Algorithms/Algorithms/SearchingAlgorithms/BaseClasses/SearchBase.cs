using Algorithms.Helpers;
using System;
using System.Diagnostics;
using System.Linq;

namespace Algorithms.SearchingAlgorithms.BaseClasses
{
    public abstract class SearchBase : ISearchable
    {
        private Stopwatch _stopWatch = new Stopwatch();

        public int[] intArr { get; set; }

        public abstract bool Search(int[] arr, int elementToFind);

        public void PrintArray(int[] arr)

        {
            arr.ToList().ForEach(n => Console.Write($"{n},"));
            Console.WriteLine();
        }

        void ITimeable.StartTimer()
        {
            _stopWatch.Start();
        }

        void ITimeable.StopTimer()
        {
            _stopWatch.Start();
        }

        void ITimeable.ResetTimer()
        {
            _stopWatch.Reset();
        }

        void ITimeable.PrintElapsedTime()
        {
            Console.WriteLine($"Elapsed Time (milliseconds): {_stopWatch.ElapsedMilliseconds}");
        }
    }
}