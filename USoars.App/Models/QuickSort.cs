﻿// <auto-generated>
// This file contains the QuickSort class of SortingApp.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </auto-generated>

namespace SortingApp.Models
{
    /// <summary>
    /// Represents the QuickSort algorithm.
    /// </summary>
    public class QuickSort : ISortStrategy
    {
        /// <inheritdoc/>
        public string Sort(string input)
        {
            char[] array = input.ToCharArray();
            QuickSortRecursive(array, 0, array.Length - 1);
            return new string(array);
        }

        private void QuickSortRecursive(char[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortRecursive(array, low, pivotIndex - 1);
                QuickSortRecursive(array, pivotIndex + 1, high);
            }
        }

        private int Partition(char[] array, int low, int high)
        {
            char pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }

            (array[i + 1], array[high]) = (array[high], array[i + 1]);

            return i + 1;
        }
    }
}
