using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        /// <summary>
        /// Find the angle between hour and minute hands of a clock at any given time
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="mins"></param>
        public static void FindAngleinTime(int hours, int mins)
        {
            double hourDegrees = (hours * 30) + (mins * 30.0 / 60);
            double minuteDegrees = mins * 6;

            double diff = Math.Abs(hourDegrees - minuteDegrees);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine("The angle between hour hand and minute hand is {0} degrees", diff);
        }
    }
}
