namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            HotelRoom hotelRoom = new HotelRoom();
            hotelRoom.TurnOnAir().SetTemperature(72).OpenShades();

            Console.WriteLine(hotelRoom.Temperature);
                        
            Console.ReadLine();

        }

    }

    public class HotelRoom
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }

    }

    public static class ExtensionSample
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HotelRoom TurnOnAir(this HotelRoom room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoom SetTemperature(this HotelRoom room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoom OpenShades(this HotelRoom room)
        {
            room.AreShadesOpen = true;
            return room;
        }

        public static HotelRoom CloseShades(this HotelRoom room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }


}
