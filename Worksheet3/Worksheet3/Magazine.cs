using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Magazine : Publication
    {
        int orderQty;
        int currIssue;

        public int OrderQty
        {
            get { return orderQty; }
            set { orderQty = value; }
        }

        public int CurrIssue
        {
            get { return currIssue; }
            set { currIssue = value; }
        }

        public void AdjustQty(int newOrderQty)
        {
            orderQty = newOrderQty; // exactly the same as if we fetched the set for the 
            // OrderQty property
        }

        public void RecNewIssue()
        {
            currIssue++; // currIssue = currIssue + 1;
        }
    }
}
