using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Snake : Animal
    {
        public override string Eat()
        {
            return base.Eat() + " mice!";
        }

        public override string Move()
        {
            return base.Move() + " crawling!";
        }

        public override string Speak()
        {
            return base.Speak() + " ssssssssss!";
        }
    }
}
