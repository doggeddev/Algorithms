using Algorithms.Helpers;

namespace Algorithms.SortingAlgorithms.Interfaces
{
    public interface ISortAble : ITimeable, IPrintable
    {
        int[] IntArr { get; set; }

        int[] Sort(int[] arr);
    }
}