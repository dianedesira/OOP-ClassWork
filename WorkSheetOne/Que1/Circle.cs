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

        /*
         * GetRadius() is a method called for circle objects to display the circle's radius on the console
         * It has no return type (void) and no parameters (no values between brackets).
         */

        public void GetRadius() // method definition - creating our method
        {
            Console.WriteLine("The radius for this circle is " + radius);
        }
    }
}
