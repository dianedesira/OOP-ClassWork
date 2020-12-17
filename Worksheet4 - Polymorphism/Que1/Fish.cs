﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Fish : Animal
    {
        public override string Eat()
        {
            return " algae!";
        }

        public override string Move()
        {
            return base.Move() + " swimming!";
        }

        public override string Speak()
        {
            return " bloo bloo!";
        }
    }
}
