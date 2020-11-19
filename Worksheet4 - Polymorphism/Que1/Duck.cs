using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Duck : Animal
    {
        public override string Speak()
        {
            return base.Speak() + " Quack Quack!";
        }

        /*  public override string Speak()
          {
              return "Quack Quack!";
          }*/

        public override string Eat()
        {
            return base.Eat() + " pond weed and insects!";
        }

        public override string Move()
        {
            return base.Move() + " swimming!";
        }

    }
}
