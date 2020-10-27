using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(); // creating an instance of Circle thus, circle1 is a new and actual
            // circle which will have its own particular values

            Circle circle2 = new Circle();

            /*
             * To access fields and methods from an object we need to use the following format:
             * 
             * objectName.fieldName
             * objectName.MethodName()
             */

            Console.WriteLine("Circle 1:");
            circle1.radius = 2.5;
            circle1.GetRadius();

            Console.WriteLine("Circle 2:");
            circle2.radius = 4.8;
            circle2.GetRadius();

            Console.ReadKey(); // method call
        }
    }
}
