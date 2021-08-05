using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        // C# implementation of simple
        // algorithm to find smaller
        // element on left side

        // Prints smaller elements on
        // left side of every element
        static void printPrevSmaller(int[] arr,
                                        int n)
        {

            // Always print empty or '_'
            // for first element
            // Console.Write("_, ");
            // Start from second element
            // Simple: O(n2) 
            for (int i = 1; i < n; i++)
            {
                // look for smaller
                // element on left of 'i'
                int j;
                for (j = i - 1; j >= 0; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        Console.Write(arr[j]
                                    + ", ");
                        break;
                    }
                }

                // If there is no smaller
                // element on left of 'i'
                if (j == -1)
                    Console.Write("_, ");
            }
        }

        // Prints smaller elements on left side of every element 
        static void printPrevSmallerNew(int[] arr, int n)
        {
            // Create an empty stack
            Stack<int> S = new Stack<int>();

            // Traverse all array elements
            for (int i = 0; i < n; i++)
            {
                // Keep removing top element from S while the top
                // element is greater than or equal to arr[i]
                while (S.Count != 0 && S.Peek() >= arr[i])
                {
                    S.Pop();
                }

                // If all elements in S were greater than arr[i]
                if (S.Count == 0)
                {
                    Console.Write("_, ");
                }
                else //Else print the nearest smaller element
                {
                    Console.Write(S.Peek() + ", ");
                }

                // Push this element
                S.Push(arr[i]);
            }
        }
    }
}
