using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Lion : Animal
    {
        public override string Eat()
        {
            return base.Eat() + " buffalos!";
        }

        public override string Move()
        {
            return base.Move() + " creep to catch prey!";
        }

        public override string Speak()
        {
            return base.Speak() + " Roooaarrr!";
        }
    }
}
