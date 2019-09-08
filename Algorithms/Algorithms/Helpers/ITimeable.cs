namespace Algorithms.Helpers
{
    public interface ITimeable
    {
        void StartTimer();

        void StopTimer();

        void ResetTimer();

        void PrintElapsedTime();
    }
}