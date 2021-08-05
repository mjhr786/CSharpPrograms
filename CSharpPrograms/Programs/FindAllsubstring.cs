using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Find all possible substring of a given string
        /// </summary>
        /// <param name="str"></param>
        public static void FindAllsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + "\n");
                }
            }

            //Alternate solution
            string value = str;
            // Avoid full length.
            for (int length = 1; length < value.Length; length++)
            {
                // End index is tricky.
                for (int start = 0; start <= value.Length - length; start++)
                {
                    string substring = value.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
