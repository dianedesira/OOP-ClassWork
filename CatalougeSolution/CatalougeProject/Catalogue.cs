using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalougeProject
{
    class Catalogue
    {
        List<ItemForSale> itemsForSale = new List<ItemForSale>();
        List<Page> pages = new List<Page>();

        public List<ItemForSale> ItemsForSale { get => itemsForSale; set => itemsForSale = value; }
        public List<Page> Pages { get => pages; set => pages = value; }

        public void AddItem(ItemForSale item)
        {
            itemsForSale.Add(item);
            if (itemsForSale.Count % 2 != 0)
            {
                AddPage();
            }
        }

        public void AddPage()
        {
            Page newPage = new Page(Pages.Count + 1);
            Pages.Add(newPage);
            //pages.Add(new Page(pages.Count + 1));
        }

    }
}
