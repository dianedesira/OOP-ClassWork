using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Dog : Animal
    {
        public override string Speak()
        {
            return base.Speak() + " Wuuf Wuuf!";
        }

        /*public override string Speak()
        {
            return "Wuuf Wuuf!";
        }*/

        public override string Eat()
        {
            return base.Eat() + " bones!";
        }

        public override string Move()
        {
            return base.Move() + " running happily!";
        }

    }
}
