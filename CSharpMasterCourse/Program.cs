
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

            Address address = new Address();
            address.Street = "Casiana";
            address.City = "Bacolod";
            address.State = "Negros";
            address.Zip = "6100";

            Console.WriteLine(address.FullAddress);


            Console.Beep();
            Console.ReadLine();
        }

    }
}


