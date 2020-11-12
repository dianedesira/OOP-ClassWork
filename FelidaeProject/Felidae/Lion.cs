using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felidae
{
    class Lion : Felidae
    {
        int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Lion(bool male, int weight) : base(male)
        {
            this.weight = weight;
        }

 
    }
}
