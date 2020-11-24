using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalougeProject
{
    class Shop
    {
        List<ItemForSale> itemsToSell = new List<ItemForSale>();

        public List<ItemForSale> ItemsToSell { get => itemsToSell; set => itemsToSell = value; }

        public void AddItemToSell(ItemForSale item)
        {
            itemsToSell.Add(item);
        }

        public string ListOfItemsToSell()
        {
            string returnText = "";

            foreach (ItemForSale item in itemsToSell)
            {
                returnText += "\n" + item.Name;
            }

            return returnText;
        }
    }
}
