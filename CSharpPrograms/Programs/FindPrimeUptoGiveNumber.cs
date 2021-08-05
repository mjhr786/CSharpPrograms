using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        public static void FindPrimeUptoGivenNumber()
        {
            bool notPrime = false;
            int j;
            int target = 150;

            for (int i = 2; i <= target; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

                if (!notPrime)
                    Console.Write("{0} ", j);
                else
                    notPrime = false;
            }
        }
    }
}
