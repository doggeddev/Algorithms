namespace Algorithms.SortingAlgorithms.Interfaces
{
    public interface ISortAble : ITimeable, IPrintable
    {
        int[] intArr { get; set; }

        int[] Sort(int[] arr);
    }

    public interface ITimeable
    {
        void StartTimer();

        void StopTimer();

        void ResetTimer();

        void PrintElapsedTime();
    }

    public interface IPrintable
    {
        void PrintArray(int[] arr);
    }
}