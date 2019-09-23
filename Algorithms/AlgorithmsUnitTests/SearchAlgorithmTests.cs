namespace SearchAlgorithmsUnitTests
{    
    using Algorithms.SearchingAlgorithms.Algorithms;
    using Algorithms.SearchingAlgorithms.BaseClasses;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SearchAlgorithmTests
    {
        public readonly int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        [TestMethod]
        public void BinarySearchTest_ValueToFindExists()
        {
            int valueToFind = 3;

            ISearchable binarySearch = new BinarySearch();

            Assert.IsTrue(binarySearch.Search(arr, valueToFind));
        }

        [TestMethod]
        public void BinarySearchTest_ValueToFindDoesNotExist()
        {
            int valueToFind = 100;

            ISearchable binarySearch = new BinarySearch();

            Assert.IsFalse(binarySearch.Search(arr, valueToFind));
        }
    }
}
