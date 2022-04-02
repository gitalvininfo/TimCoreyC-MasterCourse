namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            IVehicle vehicle = new Car();
            vehicle.Start();
            vehicle.Stop();
            vehicle.Gas();
            vehicle.Manufacturer = "Ferrari";
            Console.WriteLine(vehicle.Manufacturer);

        }

    }

    public abstract class Vehicle : IVehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }

        public void Gas()
        {
            Console.WriteLine("Gas");
        }

        public void Start()
        {
            Console.WriteLine("Start");

        }

        public void Stop()
        {
            Console.WriteLine("Stop");

        }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;
    }

    public interface IVehicle
    {
        string VIN { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        int YearManufactured { get; set; }

        void Start();
        void Stop();
        void Gas();
    }




}