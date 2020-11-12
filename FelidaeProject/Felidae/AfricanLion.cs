using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felidae
{
    class AfricanLion : Lion
    {
        /* We are forced to create an AfricanLion constructor with AT LEAST a boolean and an
         * integer since there is a restriction (on constructors) in the Lion class.
         * In the Lion class it is indicated that for every Lion to be created the gender and
         * weight need to be indicated.
         * Since the AfricanLion IS A Lion, then to create an AfricanLion as well, the gender
         * and weight need to be indicated. The restriction will keep on going down the 
         * hierarchy, i.e. it will follow any other classes which inherit the Lion or 
         * AfricanLion.
         */

        public AfricanLion(bool male, int weight) :base(male, weight)
        {   }

        public override string ToString()
        {
            return "This object is an AfricanLion, male? " + Male + " and weight is " +
                Weight;
        }

    }
}
