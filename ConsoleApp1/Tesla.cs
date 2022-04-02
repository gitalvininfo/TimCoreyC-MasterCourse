namespace ConsoleApp1
{
    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Think about your destination.");
        }

        public override void StartClock()
        {
            Console.WriteLine("It sets itself.");
        }
    }


}