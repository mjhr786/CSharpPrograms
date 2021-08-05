using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    //Implement an algorithm to determine if a string has all unique characters.
    //What if you cannot use additional data structures?
    partial class Program
    {
        //Uses a dictionary to store each character and checks for a duplicate entry
        public static bool IsUnique(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                    return false;
                else
                    d.Add(c, 1);
            }
            return true;
        }

        //Compares each character to every other character without using an additional data structure
        //O(n^2) time complexity
        public static bool IsUnique1(string s)
        {
            string temp1 = "";
            string temp2 = "";

            for (int i = 0; i < s.Length; i++)
            {
                temp1 = s.Substring(i, 1);
                for (int k = 0; k < s.Length; k++)
                {
                    temp2 = s.Substring(k, 1);
                    if ((temp1 == temp2) && (i != k))
                        return false;
                }
            }
            return true;
        }
    }
}
