using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felidae
{
    class Felidae
    {

        bool male;

        public bool Male
        {
            get { return male; }
            set { male = value; }
        }

        public Felidae() : this(true)
        {
        }

        public Felidae(bool male)
        {
            this.male = male;
        }
    }
}
