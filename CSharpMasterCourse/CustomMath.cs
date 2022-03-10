using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public static class CustomMath
    {

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if(x == 0 || y == 0)
            {
                return 0;
            }

            return x / y;
        }
    }
}
