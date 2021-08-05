using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    // https://www.geeksforgeeks.org/bubble-sort/
    // https://www.geeksforgeeks.org/comparison-among-bubble-sort-selection-sort-and-insertion-sort/
    partial class Program
    {
        // C# program for implementation
        // of Bubble Sort
        public static void BubbleSortExample()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort(arr);
            Console.WriteLine("Bubble Sorted array");
            printBBLArray(arr);
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        /* Prints the array */
        static void printBBLArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
