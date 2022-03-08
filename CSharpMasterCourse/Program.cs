
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


            for(int i = 0; i < 20; i++)
            {
                Console.Write($"{i}");

                for(int j = 0; j < 20; i++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }


            Console.Beep();
            Console.ReadKey();
        }

    }
}







