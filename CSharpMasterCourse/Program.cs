
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
            try
            {
                SimpleMethod();
            }
            catch (AccessViolationException ex)
            {
                Console.WriteLine(ex);
            }


            Console.Beep();
            Console.ReadKey();
        }


        private static void SimpleMethod()
        {
            throw new AccessViolationException("You should not access this memory dog!");
        }



    }
}







