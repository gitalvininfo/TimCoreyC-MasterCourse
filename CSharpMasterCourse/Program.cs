
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

            List<Person> people = new List<Person>();
            string firstName = "";
            string lastName = "";
            int age = 0;
            string streetName = "";
            string cityName = "";

            do
            {
                Console.Write("First name: ");
                firstName = Console.ReadLine();

                Console.Write("Last name: ");
                lastName = Console.ReadLine();

                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Streetname: ");
                streetName = Console.ReadLine();

                Console.Write("Cityname: ");
                cityName = Console.ReadLine();


                Person person = new Person();
                person.FirstName = firstName;
                person.LastName = lastName;
                person.Age = age;
                person.CompleteAddress = new Address();
                person.CompleteAddress.StreetName = streetName;
                person.CompleteAddress.CityName = cityName;

                people.Add(person);


            } while (firstName.ToLower() != "exit");


            foreach(Person p in people)
            {
                Console.WriteLine(p.displayData());
            }
            

            Console.Beep();
            Console.ReadLine();
        }

    }
}


