using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Bird : Animal
    {
        public override string Eat()
        {
            return base.Eat() + " worms!";
        }

        public override string Move()
        {
            return base.Move() + " flying!";
        }

        public override string Speak()
        {
            return base.Speak() + " tweet tweet!";
        }
    }
}
