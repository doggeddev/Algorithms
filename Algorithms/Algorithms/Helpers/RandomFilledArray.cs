using System;

namespace Algorithms.Helpers
{
    internal interface IRandomArray
    {
        int[] GetRandomIntegerArray();
    }

    internal class RandomFilledArray : IRandomArray
    {
        private Random _random = new Random();
        private int _arrayLength = -1;
        private int _minValue = 0;
        private int _maxValue = int.MaxValue;

        public RandomFilledArray(int arrayLength)
        {
            this._arrayLength = arrayLength;
        }

        public RandomFilledArray(int arrayLength, int minValue, int maxValue)
        {
            this._arrayLength = arrayLength;
            this._minValue = minValue;
            this._maxValue = maxValue;
        }

        public int[] GetRandomIntegerArray()
        {
            return CreateNewIntegerArray(this._arrayLength);
        }

        private int[] CreateNewIntegerArray(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = _random.Next(this._minValue, this._maxValue);
            }

            return array;
        }
    }
}