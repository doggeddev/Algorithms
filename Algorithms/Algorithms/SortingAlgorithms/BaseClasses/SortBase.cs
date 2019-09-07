using Algorithms.SortingAlgorithms.Interfaces;
using System;
using System.Diagnostics;
using System.Linq;

namespace Algorithms.SortingAlgorithms
{
    public abstract class SortBase : ISortAble
    {
        private Stopwatch _stopWatch = new Stopwatch();

        public int[] intArr { get; set; }

        public abstract int[] Sort(int[] arr);

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