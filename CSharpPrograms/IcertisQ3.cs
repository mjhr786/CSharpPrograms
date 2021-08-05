using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class IcertisQ3
    {
		/// <summary>
		/// ans = BC
		/// </summary>
        public static void f2()
        {
			try
			{
				int[] array = new int[3];
				array[3] = 3;
				Console.Write("A");

			}
			catch (IndexOutOfRangeException)
			{
				Console.Write("B");
			}
			Console.Write("C");
		}

		public static int f3()
		{
			string s = "Hello\0world";
			return s.Length;
		}
    }
}
