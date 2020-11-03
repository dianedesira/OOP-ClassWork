using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Circle
    {
        // line comment
        public double radius; // radius is a field for the Circle type
        Random rand = new Random();
        /*
         * GetRadius() is a method called for circle objects to display the circle's radius on the console
         * It has no return type (void) and no parameters (no values between brackets).
         */

        public Circle(double radius)
        {
            this.radius = radius;
            /*
             * the this keyword refers to THIS current Circle object 
             * we are making the radius attribute for this current circle equal to the radius value whic
             * is passed as a parameter/argument
             */
        }

        public string GetRadius() // method definition - creating our method
        {
            radius = rand.Next(1, 31);
            string returnedText = "The radius for this circle is " + radius;

            return returnedText;

            /*
             * OR simply:
             * return "The radius for this circle is " + radius;
             */
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return Math.Round(area,2);
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return Math.Round(circumference,2);
        }
    }
}
