using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        static void FindMaxOfThree()
        {
            int num1, num2, num3;
            // set the value of the three numbers
            num1 = 10;
            num2 = 20;
            num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");

            // Find Max of 3 using Math class
            int max = Math.Max(10, Math.Max(20, 30));
            Console.WriteLine(max);
        }
    }
}
