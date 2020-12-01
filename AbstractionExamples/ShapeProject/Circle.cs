using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Circle : Shape
    {
        double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            area = Math.PI * Math.Pow(radius, 2); // Math.PI * radius * radius;
        }
    }
}
