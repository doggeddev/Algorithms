using Algorithms.Helpers;

namespace Algorithms.SearchingAlgorithms.BaseClasses
{
    public interface ISearchable : ITimeable, IPrintable
    {
        bool Search(int[] arr, int elementToFind);
    }
}