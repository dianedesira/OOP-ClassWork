using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject
{
    class Room
    {
        double length;
        double width;
        double height;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public Room(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public Room()
        {
            length = 1; width = 1; height = 1;
        }
    }
}
