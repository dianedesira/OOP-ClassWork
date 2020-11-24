using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalougeProject
{
    class ItemForSale
    {
        string name;
        double price;
        public string Name { get => name; set => name = value; }
        public double Price { get => price;} // read only

        public ItemForSale(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }
    }

}
