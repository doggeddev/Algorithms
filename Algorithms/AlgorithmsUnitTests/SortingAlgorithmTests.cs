namespace SortingAlgorithmsUnitTests
{
    using Algorithms.SortingAlgorithms;
    using Algorithms.SortingAlgorithms.Algorithms;
    using Algorithms.SortingAlgorithms.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SortingAlgorithmTests
    {
        public readonly int[] arr = { 1, 9, 2, 8, 3, 7, 4, 6, 5 };

        [TestMethod]
        public void BubbleSortTest_ArrIsSorted()
        {
            ISortAble bubbleSort = new BubbleSort();

            int[] sorted = bubbleSort.Sort(arr);

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                Assert.IsTrue(sorted[i] <= sorted[i + 1]);
            }
        }

        [TestMethod]
        public void SelectionSortTest_ArrIsSorted()
        {
            ISortAble SelectionSort = new SelectionSort();

            int[] sorted = SelectionSort.Sort(arr);

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                Assert.IsTrue(sorted[i] <= sorted[i + 1]);
            }
        }

        [TestMethod]
        public void InsertionSortTest_ArrIsSorted()
        {
            ISortAble insertionSort = new InsertionSort();

            int[] sorted = insertionSort.Sort(arr);

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                Assert.IsTrue(sorted[i] <= sorted[i + 1]);
            }
        }

        [TestMethod]
        public void MergeSortTest_ArrIsSorted()
        {
            ISortAble mergeSort = new MergeSort();

            int[] sorted = mergeSort.Sort(arr);

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                Assert.IsTrue(sorted[i] <= sorted[i + 1]);
            }
        }

        [TestMethod]
        public void QuickSortTest_ArrIsSorted()
        {
            ISortAble quickSort = new QuickSort();

            int[] sorted = quickSort.Sort(arr);

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                Assert.IsTrue(sorted[i] <= sorted[i + 1]);
            }
        }
    }
}
