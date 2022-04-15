namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            
            
            Console.ReadLine();

        }

    }


    public class Person
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public void GenerateEmail()
        {
            Email = $"{FirstName}.{LastName}@aol.com";
        }

        public void GenerateEmail(string domain)
        {
            Email = $"{FirstName}.{LastName}@{domain}";

        }
    }
}
