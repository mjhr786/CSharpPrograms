using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Convert a one-dimensional array to a two-dimensional array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public static void SingleToMulti(int[] array, int row, int column)
        {
            int index = 0;
            int[,] multi = new int[row, column];

            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    multi[y, x] = array[index];
                    index++;
                    Console.Write(multi[y, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
