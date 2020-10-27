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

            Console.Write("Please enter the length for rectangle 1: ");

            /*
             * When a method returns a value the format is:
             * variable = method()
             * So method() will be converted to the returned value and the returned value will be saved
             * in the variable
             */

            rect1.length = Convert.ToDouble(Console.ReadLine());
        }
    }
}
