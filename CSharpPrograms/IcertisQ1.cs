using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    /// <summary>
    /// ans = 42
    /// </summary>
    public class IcertisQ1
    {
        static void f1(S s)
        {
            s.i += 1;
        }

        static void f3(S1 s1)
        {
            s1.i += 1;
        }

        public static String f2()
        {
            S s;
            S1 s1 = new S1();
            s1.i = 10;
            s.i = 42;
            f1(s);
            f3(s1);
            return s.i.ToString() + " ///// " + s1.i.ToString();
        }

        struct S
        {
            public int i;
        }

        public class S1
        {
            public int i;
        }
    }
}
