using System;

namespace InheritanceDemo
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
    {
        public double DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStocks -= 1;
        }

        public void Rent()
        {
            QuantityInStocks -= 1;
            Console.WriteLine("This item is rented.");
        }

        public void ReturnRental()
        {
            QuantityInStocks += 1;
            Console.WriteLine("This item has been returned.");
        }
    }




}
