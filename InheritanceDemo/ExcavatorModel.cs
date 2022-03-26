using System;

namespace InheritanceDemo
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {

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
