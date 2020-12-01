using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Rectangle : Shape
    {
        double length;
        double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override void CalculateArea()
        {
            area = length * width;
        }
    }
}
