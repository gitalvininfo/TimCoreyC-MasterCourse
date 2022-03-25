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

            List<IComputerController> controllers = new List<IComputerController>();

            controllers.Add(new Keyboard());
            controllers.Add(new Mouse());

            foreach (IComputerController controller in controllers)
            {
                if(controller is Keyboard keyboard)
                {
                }
            }

        }

    }


    public interface IComputerController
    {
        void Connect();
        void CurrentKeyPressed();
    }

    public class Keyboard : IComputerController
    {
        public void Connect()
        {
        }

        public void CurrentKeyPressed()
        {
        }

        public void EnterKeyPressed()
        {

        }
    }

    public class Mouse : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public void RightClick()
        {

        }
    }

}
