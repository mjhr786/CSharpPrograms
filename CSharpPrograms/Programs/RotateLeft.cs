using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Perform Left circular rotation of an array
        /// </summary>
        /// <param name="array"></param>
        public static void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }
            Console.Write("\n");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
