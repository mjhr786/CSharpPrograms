using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Convert a two-dimensional array to a one-dimensional array
        /// </summary>
        /// <param name="array"></param>
        public static void MultiToSingle(int[,] array)
        {
            int index = 0;
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int[] single = new int[width * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    single[index] = array[x, y];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }

            //to form 1-D array row wise
            //for (int x = 0; x < width; x++)
            //{
            //    for (int y = 0; y < height; y++)
            //    {
            //        single[index] = array[x, y];
            //        Console.Write(single[index] + " ");
            //        index++;
            //    }
            //}
        }
    }
}
