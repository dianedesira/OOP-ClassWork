using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    abstract class Animal : IEat
    {
        public abstract string Speak();

        /*
         *public virtual string Speak()
          {
            return "Hello! I am a generic animal!";
          }
         */

        public virtual string Move()
        {
            return "Animal moving";
        }

        public abstract string Eat();
        public string PrepareFood() // considering as if all of these animals are in a farm
        {
            return "Farmer preparing this animal's food";
        }

        public string PrintInformation()
        {
            return "The Animal " + GetType().Name + " makes this sound: " + Speak();
        }
    }
}
