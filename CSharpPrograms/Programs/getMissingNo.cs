using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        // a represents the array
        // n : Number of elements in array a
        static int getMissingNo(int[] a, int n)
        {
            int i, total = 1;

            for (i = 2; i <= (n + 1); i++)
            {
                total += i;
                total -= a[i - 2];
            }
            return total;
        }

        // Function to find missing number
        static int getMissingNoUsingXor(int[] a, int n)
        {
            int x1 = a[0];
            int x2 = 1;

            /* For xor of all the elements
            in array */
            for (int i = 1; i < n; i++)
                x1 = x1 ^ a[i];

            /* For xor of all the elements
            from 1 to n+1 */
            for (int i = 2; i <= n + 1; i++)
                x2 = x2 ^ i;

            return (x1 ^ x2);
        }

        /// <summary>
        /// Find a missing number in a sequence
        /// </summary>
        static void FindMissingNumber()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12 };
            int result = 0;
            var sum = arr.Sum();
            for (int i = 1; i <= (arr.Length + 1); i++)
            {
                result += i;
            }
            Console.WriteLine($"Sum = {sum} and Total = {result} and Missing Number = {result - sum}");
        }
    }
}
