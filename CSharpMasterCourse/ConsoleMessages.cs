using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public static class ConsoleMessages
    {
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        
        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye User");
        }

        public static string GetUsersName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }
    }
}
