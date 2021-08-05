using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Remove duplicate characters from a string
        /// </summary>
        /// <param name="str"></param>
        public static void Removeduplicate(string str)
        {
            string result = string.Empty;
            string result1 = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }

            //alternate solution
            foreach (char value in str)
            {
                // See if character is in the table.
                if (result1.IndexOf(value) == -1)
                {
                    // Append to the result.
                    result1 += value;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Removing Duplicate entries through traditional for loop
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static string[] RemoveDuplicates(string[] inputArray)
        {

            int length = inputArray.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = (i + 1); j < length;)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        for (int k = j; k < length - 1; k++)
                            inputArray[k] = inputArray[k + 1];
                        length--;
                    }
                    else
                        j++;
                }
            }

            string[] distinctArray = new string[length];
            for (int i = 0; i < length; i++)
                distinctArray[i] = inputArray[i];

            return distinctArray;

        }
    }
}
