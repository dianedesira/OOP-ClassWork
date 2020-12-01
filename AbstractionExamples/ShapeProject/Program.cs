using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Program
    {
        static void Main(string[] args)
        {/*
            List<Shape> shapes = new List<Shape>();
            shapes.AddRange(new List<Shape> {new Rectangle(3.4, 5), new Triangle(4, 2.3), new Circle(5.7),
                new Rectangle(2.3, 4.1)});
            */
            List<Shape> shapes = new List<Shape> {new Rectangle(3.4, 5), new Triangle(4, 2.3), 
                new Circle(5.7), new Rectangle(2.3, 4.1)};

            Console.WriteLine("Areas for all of the shapes:");
            Console.WriteLine("============================");
            foreach (Shape shape in shapes)
            {
                shape.CalculateArea();
                Console.WriteLine("\nThe area for the shape of " + shape.GetType().Name + " is " + 
                    shape.Area);
            }

            Console.ReadKey();
        }
    }
}
