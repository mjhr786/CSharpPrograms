using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        public static int Reverse(int number)
        {
            return int.Parse(number.ToString().Reverse().ToArray());
        }

        public static void ReverseNumber()
        {
            int n = 54321;
            int left = n;
            int reverse = 0;
            while (Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
            {
                int remainder = left % 10;
                reverse = reverse * 10 + remainder;
                left = left / 10;  //left = Math.floor(left / 10); 
            }

            Console.WriteLine(reverse);
        }
    }
}
