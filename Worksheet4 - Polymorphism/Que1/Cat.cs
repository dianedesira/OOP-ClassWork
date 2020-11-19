using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Cat : Animal
    {
        public override string Speak()
        {
            return base.Speak() + " Meeeoww!";
        }

        /* public override string Speak()
         {
             return "Meeeoww!";
         }*/

        public override string Eat()
        {
            return base.Eat() + " cat food!";
        }

        public override string Move()
        {
            return base.Move() + " cat walk :)!";
        }

    }
}
