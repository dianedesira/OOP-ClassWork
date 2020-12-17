using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Farmer : IEat
    {
        public string PrepareFood()
        {
            return "If all required food is at home, food is cooked";
        }

        public string Eat()
        {
            return "Sit on a table and eat prepared food";
        }
    }
}
