using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms.Programs
{
    class SortReverseArray
    {
        // Write a method to sort the elements of an array in descending order
        public static void Sort(int[] x)
        {
            Array.Sort(x);
            Array.Reverse(x);
        }

        // C# Program to Reverse an Array
        public static void Reverse()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(array);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
