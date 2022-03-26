using System;

namespace InheritanceDemo
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStocks -= 1;
            Console.WriteLine("This item is purchased. " + ProductName);
        }
    }




}
