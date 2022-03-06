using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public static class Homework
    {

        public static void Welcome()
        {
            Console.WriteLine("Welcome User!");
        }

        public static string GetUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        public static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
