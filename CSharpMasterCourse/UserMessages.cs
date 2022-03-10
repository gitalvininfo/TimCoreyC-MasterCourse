using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public class UserMessages
    {

        public static void ApplicationStartMessage(string firstname)
        {
            Console.WriteLine("Welcome to the static class demo app.");


            int hourOfDay = DateTime.Now.Hour;

            if(hourOfDay < 12)
            {
                Console.WriteLine($"Good Morning {firstname}");
            }   else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon {firstname}");
            }   else
            {
                Console.WriteLine($"Good Evening {firstname}");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();

            Console.WriteLine("Thank you for choosing our app to calculate for you.");
        }

    }
}
