using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} = {x + y}");

            return x + y;
        }

        public static void AddAll(double[] values)
        {

            double total = 0;

            //for (double i = 0; i < values.Length; i++)
            //{
            //    total += values[(int)i];
            //}

            foreach(double value in values)
            {
                total += value;
            }

            //values.Sum();

            Console.WriteLine($"The total is {total}");
        }
    }
}
