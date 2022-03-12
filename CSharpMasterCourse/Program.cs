
using GuestBookingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capture the information about each guest
// Info to capture: Firstname, lastname, message to the host
// Once done, loop through each guest and print their info


namespace CSharpMasterCourse
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();


        static void Main(string[] args)
        {

            string moreGuestToCome = "";

            do
            {
                GuestModel guest = new GuestModel();
                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                Console.Write("What is your message to the host: ");
                guest.MessageToHost = Console.ReadLine();


                Console.Write("Are more guest coming (yes/no): ");
                moreGuestToCome = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestToCome.ToLower() == "yes");


            foreach(GuestModel guest in guests)
            {
                Console.WriteLine(guest.GetGuestInfo);
            }

            Console.Beep();
            Console.ReadLine();
        }


    }
}


