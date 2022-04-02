namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person
            {
                FirstName = "alvin",
                LastName = "zobel",
                Email = "alvin@gmail.com"
            };

            Console.WriteLine(person.ToString());

        }
    }

}