
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
                BadCall();
            } catch(Exception e)
            {
                Console.WriteLine($"caller > {e}");
            }
                     

            Console.Beep();
            Console.ReadKey();
        }

        public static void BadCall()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    throw new Exception("Tim corey said I will throw");
                }
            }
        }

    }
}







