using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    abstract class Shape
    {
        string colour;
        protected double area;
        public string Colour { get => colour; set => colour = value; }
        public double Area { get => area;} // read only

        public abstract void CalculateArea();
    }
}
