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

            List<Phone> phones = new List<Phone>();
            phones.Add(new Cellphone());
            phones.Add(new Smartphone());

            foreach(var phone in phones)
            {
                if(phone is Cellphone cell)
                {
                    cell.Carrier = "";
                }
                if(phone is Smartphone smartphone)
                {
                   smartphone.
                }
            }
           
        }

    }

    public class Landline : Phone
    {

    }

    public class Smartphone : Phone
    {
        List<string> Apps = new List<string>();

        public void ConnectToInternet()
        {

        }
    }

    public class Cellphone : Phone
    {
        public string Carrier { get; set; }
    }

    public class Phone
    {
        public void PlaceCall()
        {

        }
        public void EndCall()
        {

        }
    }
}
