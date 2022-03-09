
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
            RunsALot();
            Console.Beep();
            Console.ReadKey();
        }


        private static void RunsALot()
        {
            for(int i = 0; i <= 100; i++)
            {
                if(i == 73)
                {
                    //throw new Exception(AccessViolationException e);
                }
            }
        }


    }
}







