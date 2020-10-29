using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    class Rectangle
    {
        public double length;
        public double width;

        public void CalculateArea() /* This is a method definition and a method definition explains
        how the method will execute once it is called. If it is not called, the code will never be
        executed.  */
        {
            double area = length * width; //multiplication

            Console.WriteLine("The area for this rectangle is " + area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = (length * 2) + (width * 2);

            Console.WriteLine("The perimeter for this rectangle is " + perimeter);
        }
    }
}
