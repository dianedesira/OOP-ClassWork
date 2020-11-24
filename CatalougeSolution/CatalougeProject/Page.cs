using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalougeProject
{
    class Page
    {
        int pageNumber;

        public int PageNumber { get => pageNumber; set => pageNumber = value; }

        public Page(int pageNumber)
        {
            this.pageNumber = pageNumber;
        }
    }
}
