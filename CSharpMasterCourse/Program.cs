
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

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

            GetGuestInformation();

            PrintGuestInformation();



            Console.Beep();
            Console.ReadLine();
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestInformation()
        {
            string moreGuestComing = "";


            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell the host: ");
                moreGuestComing = GetInfoFromConsole("Are more guests coming (yes/no): ");


                guests.Add(guest);


                Console.Clear();
            } while (moreGuestComing.ToLower() == "yes");

        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

    }
}


