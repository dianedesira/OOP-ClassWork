using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();
            Rectangle rect3 = new Rectangle();

            Console.Write("Please enter the length for rectangle 1: ");

            /*
             * When a method returns a value the format is:
             * variable = method()
             * So method() will be converted to the returned value and the returned value will be saved
             * in the variable
             */

            rect1.length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the width for rectangle 1: ");
            rect1.width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nRectangle 1's details:");
            rect1.CalculateArea(); // method call: the compiler will search for the method definition and
            // execute it's code
            rect1.CalculatePerimeter();

            Console.Write("\nPlease enter the length for rectangle 2: ");
            rect2.length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the width for rectangle 2: ");
            rect2.width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nRectangle 2's details:");
            rect2.CalculateArea();
            rect2.CalculatePerimeter();

            Console.Write("\nPlease enter the length for rectangle 3: ");

            rect3.length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the width for rectangle 3: ");
            rect3.width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rectangle 3's details:");
            rect3.CalculateArea();
            rect3.CalculatePerimeter();

            Console.ReadKey();
        }
    }
}
