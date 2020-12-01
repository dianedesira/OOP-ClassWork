using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Triangle : Shape
    {
        double triangleBase;
        double height;
        public double TriangleBase { get => triangleBase; set => triangleBase = value; }
        public double Height { get => height; set => height = value; }

        public Triangle(double triangleBase, double height)
        {
            this.triangleBase = triangleBase;
            this.height = height;
        }

        public override void CalculateArea()
        {
            area = (triangleBase * height) / 2;
        }
    }
}
