using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Frog : Animal
    {
        public override string Eat()
        {
            return base.Eat() + " worms!";
        }

        public override string Move()
        {
            return base.Move() + " jumping!";
        }

        public override string Speak()
        {
            return base.Speak() + " croak!";
        }
    }
}
