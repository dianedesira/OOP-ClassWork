using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Book : Publication
    {
        string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string OrderCopies(int newCopies)
        {
            //Copies += newCopies; // Calling the Copies property
            copies += newCopies; // Calling the copies field/attribute and this is possible
            //since copies has been declared as a protected field in the Base class

            return "There are " + copies + " amount of copies left";
        }
    }
}
