
using SampleLibrary;
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

            PersonModel person = new PersonModel();
            person.FirstName = "Alvin";
            person.LastName = "Yanson";

            Console.WriteLine(person.GetFullName());
           

            Console.Beep();
            Console.ReadLine();
        }

    }
}


