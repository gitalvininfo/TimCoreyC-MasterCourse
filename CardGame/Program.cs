namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.FirstName = "What is your first name: ".RequestString();
            person.LastName = "What is your last name: ".RequestString();
            person.Age = "What is your age: ".RequestInt();


            Console.WriteLine(person.FirstName);
                        
            Console.ReadLine();

        }
    }

    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while(string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt(this string message)
        {
            int output = 0;
            bool isValidInt = false;

            while (!isValidInt)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);
            }

            return output;
            
        }
    } 

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int NumberOfChildren { get; set; }
    }




}
