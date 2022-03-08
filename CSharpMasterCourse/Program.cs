
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
                Console.WriteLine("There was an exception thrown in our app.");
                Console.WriteLine($"caller > {e}");
            }
           

            Console.Beep();
            Console.ReadKey();
        }

        public static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine($"{ages[i]}");
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("we had an error");
                    Console.WriteLine($"bad call > {e.Message}");

                    /* to be catch who ever calls this shit */
                    throw new Exception("there was an error handling our array", e);
                    //throw;
                }
            }

        }

    }
}







