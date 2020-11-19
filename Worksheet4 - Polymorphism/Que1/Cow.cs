using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Cow : Animal
    {
        public override string Eat()
        {
            return base.Eat() + " grass!";
        }

        public override string Move()
        {
            return base.Move() + " stumping!";
        }

        public override string Speak()
        {
            return base.Speak() + " moo moo!";
        }
    }
}
