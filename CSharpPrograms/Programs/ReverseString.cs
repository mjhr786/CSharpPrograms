using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Reverse a string
        /// </summary>
        /// <param name="str"></param>
        public static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);

            //alternate solution
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
                result += str[i];
            Console.WriteLine(result);
        }
    }
}
