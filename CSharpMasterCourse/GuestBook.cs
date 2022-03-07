using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public static class GuestBook
    {
        public static string GetUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        public static int GetNumberOfPeople()
        {
            Console.Write("How many people you have: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}
