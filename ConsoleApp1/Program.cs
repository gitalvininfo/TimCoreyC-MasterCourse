namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Eating();

            Person employee = new Employee();
            employee.Eating();
        }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual void Eating()
        {
            Console.WriteLine("The person is eating...");
        }
    }

    public class Employee : Person
    {
        public override void Eating()
        {
            Console.WriteLine("The employee is eating.");
        }
    }

}