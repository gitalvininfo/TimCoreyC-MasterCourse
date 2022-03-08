
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    class Program
    {


        static void Main(string[] args)
        {


            int total = 0;

            for(int i = 1; i <= 5; i++)
            {
                total += 5 * i;
            }

            Console.WriteLine($"The total is {total}");


            Console.Beep();
            Console.ReadKey();
        }

    }
}







