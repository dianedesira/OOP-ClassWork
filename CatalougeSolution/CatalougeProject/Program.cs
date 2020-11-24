using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalougeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemForSale item1 = new ItemForSale("Book", 15.50);
            ItemForSale item2 = new ItemForSale("Pen", 2.30);
            ItemForSale item3 = new ItemForSale("Bag", 35.99);

           // Catalogue cat1 = new Catalogue();
           // cat1.AddItem(item1); cat1.AddItem(item2); cat1.AddItem(item3);
          //  Console.WriteLine("Number of pages in Catalogue is: " + cat1.Pages.Count);

            Shop shop1 = new Shop();
            shop1.AddItemToSell(item1); shop1.AddItemToSell(item2); 
            shop1.AddItemToSell(item3);

            Console.WriteLine("\nAll items to sell in shop:");
            Console.WriteLine("==========================");
            Console.WriteLine(shop1.ListOfItemsToSell());

            Console.ReadKey();
        }
    }
}
