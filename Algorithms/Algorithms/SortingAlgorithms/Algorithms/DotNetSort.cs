using System;

namespace Algorithms.SortingAlgorithms.Algorithms
{
    public class DotNetSort : SortBase
    {
        public override int[] Sort(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}