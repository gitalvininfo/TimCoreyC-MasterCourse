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

            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "The Subtle Art of Not Giving a Fuck", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStocks = 2 };


            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(vehicle);
            purchasables.Add(book);


            Console.Write("Do you want to rent or purchase something <yes/no>: ");
            string response = Console.ReadLine();

            if(response.ToLower() == "yes")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item <yes/no>: ");
                    string wantToRent = Console.ReadLine();

                    if(wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item <yes/no>: ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }

            else
            {

                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this item <yes/no>: ");
                    string wantToPurchase = Console.ReadLine();

                    if(wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }

            }

            Console.WriteLine("We're done");


            Console.ReadLine();

        }

    }




}
