using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Test a = new Test();
            a.b = "majahar";
            a.b = null;
            a.b = 1;
            a.b = null;

            string s = "asdasd fgdfg dfgdfg hfsf ghghg ddfd jkk  errr kikukj project aaa ddd hhhh eee hhh vvv";
            string[] stringList = s.Split(' ');
            var elem = Array.IndexOf(stringList, "project");

            SelctionSortExample();
            Console.WriteLine("Hello World!");
            var str = Console.ReadLine();

            //Reverse a string
            ReverseString(str);

            //Find if the given string is a palindrome or not
            CkhPalindrome(str);

            //reverse the order of words in a given string
            ReverseWordOrder(str);

            //Reverse each word in a given string
            ReverseWords(str);

            //Count the occurrence of each character in a string
            CountCharacter(str);

            //Remove duplicate characters from a string
            Removeduplicate(str);

            //Find all possible substring of a given string
            FindAllsubstring(str);

            //Perform Left circular rotation of an array
            RotateLeft(new int[] { 1, 2, 3, 4, 5 });

            //Perform Right circular rotation of an array
            RotateRight(new int[] { 1, 2, 3, 4, 5 });

            //Find if a positive integer is a prime number or not
            if (FindPrime(48))
            {
                Console.WriteLine("\n Prime");
            }
            else
            {
                Console.WriteLine("\n Not Prime");
            }

            //Find the sum of digits of a positive integer
            SumOfDigits(168);

            //Find second largest integer in an array using only one loop
            FindSecondLargeInArray(new int[] { 1, 2, 3, 4, 5 });

            //Convert a two-dimensional array to a one-dimensional array
            MultiToSingle(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });

            //Convert a one-dimensional array to a two-dimensional array
            SingleToMulti(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 3);

            //Find the angle between hour and minute hands of a clock at any given time
            FindAngleinTime(9, 30);
                        
            //Remove duplicate from Array
            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            int n = arr.Length;

            n = GFG.RemoveDuplicates(arr, n);

            // Print updated array 
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

            //Remove duplicate from Array
            int n1 = arr.Length;

            n1 = RemDupl.RemoveDuplicates(arr, n);

            Console.Write("\n");
            // Print updated array 
            for (int i = 0; i < n1; i++)
                Console.Write(arr[i] + " ");

            //Removing Duplicate entries through traditional for loop
            string[] inputArray = { "array", "array", "distinct", "elememnt", "remove", "distinct", "delete", "delete", "delete" };
            string[] distinctArray = RemoveDuplicates(inputArray);

            Console.Write("\n");
            // Print updated array 
            for (int i = 0; i < distinctArray.Length; i++)
                Console.Write(distinctArray[i] + " ");

            //Sort list without using sort function
            SortList(new List<int> { 4, 1, 3, 2 });

            //Count the number of words in a string
            WordCount(str);

            //Icertis apti Question 1
            Console.WriteLine($"Outpu of Q1 = {IcertisQ1.f2()}");

            //Icertis apti Question 2
            Console.WriteLine($"Outpu of Q2 = {IcertisQ2.f2()}");

            //Icertis apti Question 3
            Console.WriteLine($"Outpu of Q3");
            IcertisQ3.f2();

            //Icertis apti Question 5
            Console.WriteLine($"Outpu of Q3 = {IcertisQ3.f3()}");
        }
    }

    public class Test
    {
       public object b;
    }
    
}
