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

        // tuple
        public static (string firstName, string lastName) GetFullName()
        {
            Console.Write("What is your first name: ");
            string firstname = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastname = Console.ReadLine();

            return (firstname, lastname);
        }
    }
}
