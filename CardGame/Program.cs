namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.SetDefaultAge().PrintInfo();
                        
            Console.ReadLine();

        }
    }
    public class Person
    {
        public int Age { get; set; }

        public Person()
        {
        }
    }

    public static class ExtensionSample
    {
        public static Person SetDefaultAge(this Person person)
        {
            person.Age = 18;
            return person;
        }

        public static void PrintInfo(this Person person)
        {
            Console.WriteLine($"{person.Age}");
        }
    }



}
