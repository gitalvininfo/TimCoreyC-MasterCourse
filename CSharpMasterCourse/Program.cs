
using DemoLibrary.Models;
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

            /* user interfaces reference libraries, libraries does not reference user interfaces */
            PersonModel person = new PersonModel();

            person.FirstName = "Tim";
            person.LastName = "Corey";

            Console.WriteLine(person.FirstName);

            Console.Beep();
            Console.ReadLine();
        }

    }
}


