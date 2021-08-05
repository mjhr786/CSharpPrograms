using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Find if a positive integer is a prime number or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static void CheckPrime()
        {
            int i, j;
            i = 100;

            for (j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    Console.WriteLine("{0} is not prime", i);
                    break;
                }
            }
            if (j == i)
            {
                Console.WriteLine("{0} is prime", i);
            }
            Console.ReadLine();
        }
    }
}
