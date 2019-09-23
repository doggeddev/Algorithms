using System;

namespace Algorithms.Helpers
{
    public static class AddValueAtRandomArrayIndex
    {
        public static int[] InsertValue(int[] arrayToCopy, int value = 12345)
        {
            int[] arr = new int[arrayToCopy.Length];

            Array.Copy(arrayToCopy, arr, arrayToCopy.Length);

            Random rand = new Random();

            int i = rand.Next(arr.Length);

            arr[i] = value;

            return arr;
        }
    }
}