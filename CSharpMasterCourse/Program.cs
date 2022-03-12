
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGEZ;

namespace CSharpMasterCourse
{
    class Program
    {

        static void Main(string[] args)
        {

            double result = Calculate.Multiply(4, 3);
            Console.WriteLine(result);

            Console.Beep();
            Console.ReadLine();
        }

    }
}


