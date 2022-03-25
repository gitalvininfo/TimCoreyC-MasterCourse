using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle vehicle = new Vehicle();
            Boat boat = new Boat();
            boat.Start();
        }

    }

    public class Vehicle
    {
        public void Start()
        {

        }
        public void Stop()
        {

        }
    }

    public class Boat : Vehicle
    {

    }

    public class Car : Vehicle
    {

    }

    public class Motorcycle : Vehicle
    {

    }

}
