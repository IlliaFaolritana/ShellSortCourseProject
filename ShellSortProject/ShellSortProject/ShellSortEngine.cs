using System.Drawing;
using System.Threading;

namespace ShellSortProject
{
    public delegate void UpdateComparisonsDelegate(uint comparisons);
    public delegate void UpdatePermutationsDelegate(uint permutations);
    class ShellSortEngine : ISortEngine
    {
        private enum Sort { Classic, Sedgewick, Fibonacci, Tokuda }
        private readonly int[] sedgewickSequence = { 36289, 16001, 8929, 3905, 2161, 929, 505, 209, 109, 41, 19, 5, 1 };
        private readonly int[] fibonacciSequence = { 46368, 28657, 17711, 10946, 6765, 4181, 2584, 1597, 987,
                                                     610, 377, 233, 144, 89, 55, 34, 21, 13, 8, 5, 3, 2, 1 };
        private readonly int[] tokudaSequence = { 30301, 13467, 5985, 2660, 1182, 525, 233, 103, 46, 20, 9, 4, 1 };


        private readonly int[] mainArray;
        private readonly int selectedSortOption;
        uint comparisons;
        uint permutations;

        private readonly UpdateComparisonsDelegate updateComparisons;
        private readonly UpdatePermutationsDelegate updatePermutations;
        private delegate bool SortingOrderDelegate (int index1, int index2);
        private readonly SortingOrderDelegate sortingOrderComparator_Swapped;

        private readonly Graphics g;
        private readonly Brush whiteBrush = new SolidBrush (Color.White);
        private readonly Brush blackBrush = new SolidBrush (Color.Black);
        private readonly Brush redBrush = new SolidBrush (Color.Red);
        private readonly float heightScale;
        private readonly float widthScale;
        private readonly float maxValue;

        private readonly int sleeptime = 1;
        private readonly int endSleeptime = 1000;

        public ShellSortEngine(int[] mainArray, int selectedSortOption, bool descendingOrder,
                               UpdateComparisonsDelegate updateComparisons, UpdatePermutationsDelegate updatePermutations)
        {
            this.mainArray = mainArray;
            this.selectedSortOption = selectedSortOption;
            this.updateComparisons = updateComparisons;
            this.updatePermutations = updatePermutations;
            if (descendingOrder)
                sortingOrderComparator_Swapped = DescendingComparator;
            else
                sortingOrderComparator_Swapped = AscendingComparator;
        }
        public ShellSortEngine(int[] mainArray, int selectedSortOption, bool descendingOrder,
                       UpdateComparisonsDelegate updateComparisons, UpdatePermutationsDelegate updatePermutations,
                       Graphics g, float heightScale, float widthScale, float maxValue)
        {
            this.mainArray = mainArray;
            this.selectedSortOption = selectedSortOption;
            this.updateComparisons = updateComparisons;
            this.updatePermutations = updatePermutations;
            if (descendingOrder)
                sortingOrderComparator_Swapped = DescendingComparatorVisualization;
            else
                sortingOrderComparator_Swapped = AscendingComparatorVisualization;
            this.g = g;
            this.heightScale = heightScale;
            this.widthScale = widthScale;
            this.maxValue = maxValue;
        }
        public void DoSort()
        {
            switch (selectedSortOption)
            {
                case (int)Sort.Classic:
                    ShellSortClassic();
                    break;
                case (int)Sort.Sedgewick:
                    ShellSortSequence(sedgewickSequence);
                    break;
                case (int)Sort.Fibonacci:
                    ShellSortSequence(fibonacciSequence);
                    break;
                case (int)Sort.Tokuda:
                    ShellSortSequence(tokudaSequence);
                    break;
                default:
                    break;
            }
        }
        private void ShellSortClassic()
        {
            int gap;
            int n = mainArray.Length;
            for (gap = n / 2; gap >= 1; gap /= 2)
            {
                for (int j = gap; j < n; j++)
                {
                    for (int i = j - gap; i >= 0; i -= gap)
                    {
                        comparisons++;
                        if (!sortingOrderComparator_Swapped(i, i + gap))
                            break;
                    }
                }
            }
            updateComparisons(comparisons);
            updatePermutations(permutations);
            if (g != null)
                Thread.Sleep(endSleeptime);
        }
        private void ShellSortSequence(int[] sequence)
        {
            int gap;
            int n = mainArray.Length;
            for (int k = 0; k < sequence.Length ; k++)
            {
                gap = sequence[k];
                if (gap >= n)
                    continue;
                for (int j = gap; j < n; j++)
                {
                    for (int i = j - gap; i >= 0; i -= gap)
                    {
                        comparisons++;
                        if (!sortingOrderComparator_Swapped(i, i + gap))
                            break;
                    }
                }
            }
            updateComparisons(comparisons);
            updatePermutations(permutations);
            if (g != null)
                Thread.Sleep(endSleeptime);
        }
        private bool AscendingComparator(int i, int iPlusGap)
        {
            if (mainArray[i] > mainArray[iPlusGap])
            {
                (mainArray[i], mainArray[iPlusGap]) = (mainArray[iPlusGap], mainArray[i]);
                permutations++;
                return true;
            }
            return false;
        }
        private bool DescendingComparator(int i, int iPlusGap)
        {
            if (mainArray[i] < mainArray[iPlusGap])
            {
                (mainArray[i], mainArray[iPlusGap]) = (mainArray[iPlusGap], mainArray[i]);
                permutations++;
                return true;
            }
            return false;
        }
        private bool AscendingComparatorVisualization(int i, int iPlusGap)
        {
            CompareValuesVisualization(i, iPlusGap);
            if (mainArray[i] > mainArray[iPlusGap])
            {
                (mainArray[i], mainArray[iPlusGap]) = (mainArray[iPlusGap], mainArray[i]);
                permutations++;
                ChangeValuesVisualization(i, iPlusGap);
                return true;
            }
            UncompareValuesVisualization(i, iPlusGap);
            return false;
        }
        private bool DescendingComparatorVisualization(int i, int iPlusGap)
        {
            CompareValuesVisualization(i, iPlusGap);
            if (mainArray[i] < mainArray[iPlusGap])
            {
                (mainArray[i], mainArray[iPlusGap]) = (mainArray[iPlusGap], mainArray[i]);
                permutations++;
                ChangeValuesVisualization(i, iPlusGap);
                return true;
            }
            UncompareValuesVisualization(i, iPlusGap);
            return false;
        }
        private void CompareValuesVisualization(int index1, int index2)
        {
            g.FillRectangle(redBrush, index1 * widthScale, maxValue - mainArray[index1] * heightScale, widthScale, maxValue);
            g.FillRectangle(redBrush, index2 * widthScale, maxValue - mainArray[index2] * heightScale, widthScale, maxValue);
            Thread.Sleep(sleeptime);
        }
        private void UncompareValuesVisualization(int index1, int index2)
        {
            g.FillRectangle(whiteBrush, index1 * widthScale, maxValue - mainArray[index1] * heightScale, widthScale, maxValue);
            g.FillRectangle(whiteBrush, index2 * widthScale, maxValue - mainArray[index2] * heightScale, widthScale, maxValue);
        }
        private void ChangeValuesVisualization(int index1, int index2)
        {
            g.FillRectangle(blackBrush, index1 * widthScale, 0, widthScale, maxValue);
            g.FillRectangle(blackBrush, index2 * widthScale, 0, widthScale, maxValue);

            g.FillRectangle(whiteBrush, index1 * widthScale, maxValue - mainArray[index1] * heightScale, widthScale, maxValue);
            g.FillRectangle(whiteBrush, index2 * widthScale, maxValue - mainArray[index2] * heightScale, widthScale, maxValue);
        }
    }
}
