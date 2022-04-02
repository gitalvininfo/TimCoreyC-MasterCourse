namespace ConsoleApp1
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }

        public abstract void StartClock();
        
    }


}