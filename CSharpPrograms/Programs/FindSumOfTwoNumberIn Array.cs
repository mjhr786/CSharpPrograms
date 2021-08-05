using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        public static void FindSumOfTwoNumbersInArray()
        {
            // Find sum of tow number in array equal two another number k
            int[] arr = { 1, 3, 4, 5, 6, 7, 8, 9 };
            int k = 10;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == k)
                    {
                        Console.WriteLine($"Sum of Two numbers {arr[i]} + {arr[j]} is equal to {k}");
                    }
                }
            }

            // Find Sum of two numbers in array
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        continue;
                    }
                    Console.WriteLine($"Sum of {arr[i]} + {arr[j]} = {arr[i] + arr[j]}");
                }
            }
        }
    }
}
