using System;

namespace ShellSortProject
{
    class ArrayGenerator
    {
        private enum Order { Random, Ascending, Descending }
        readonly int arraySize;
        readonly int maxValue;
        readonly int minValue;
        int[] mainArray;
        public ArrayGenerator(int arraySize, int maxValue, int minValue) 
        {
            this.arraySize = arraySize;
            this.maxValue = maxValue;  
            this.minValue = minValue;
        }
        public int[] GetGeneratedArray(int order)
        {
            mainArray = new int[arraySize];
            GenerateArray();
            switch (order)
            {
                case (int)Order.Random:
                    return mainArray;
                case (int)Order.Ascending:
                    Array.Sort(mainArray);
                    return mainArray;
                case (int)Order.Descending:
                    Array.Sort(mainArray);
                    Array.Reverse(mainArray);
                    return mainArray;
                default: return mainArray;
            }
        }
        private void GenerateArray()
        {
            Random rand = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                mainArray[i] = rand.Next(minValue, maxValue + 1);
            }
        }
    }
}
