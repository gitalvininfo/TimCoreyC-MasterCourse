
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

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            string lastName = "";


            do
            {

                Console.Write("What is your firstname? ");
                firstName = Console.ReadLine();

                Console.Write("What is your lastname? ");
                lastName = Console.ReadLine();


                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;

                    people.Add(person);
                }


            } while (firstName.ToLower() != "exit");


            foreach(PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

            Console.Beep();
            Console.ReadLine();
        }

    }
}







//List<PersonModel> people = new List<PersonModel>();

//PersonModel person = new PersonModel();
//person.firstname = "alvin";
//people.Add(person);

//person = new PersonModel();
//person.firstname = "yanson";
//people.Add(person);


//foreach (PersonModel p in people)
//{
//    Console.WriteLine(p.firstname);
//}