using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    /// <summary>
    /// ans = 42045
    /// </summary>
    public class IcertisQ2
    {
        public static void f1(ref string s1, out string s2)
        {
            s1 += "0";
            s2 = "45";
        }

        public static string f2()
        {
            string s1 = "42", s2;
            f1(ref s1, out s2);
            return (s1 + s2);
        }

        class S
        {
            public int I;
        }
    }
}
