using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Sort list without using sort function
        /// </summary>
        /// <param name="li"></param>
        public static void SortList(List<int> li)
        {
            int temp;
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[j] > li[i])
                    {
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }

            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i] + "\n");
            }
        }
    }
}
