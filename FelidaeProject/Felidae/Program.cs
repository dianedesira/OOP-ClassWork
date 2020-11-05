using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felidae
{
    class Program
    {
        static void Main(string[] args)
        {
            Felidae cat1 = new Felidae();
            Felidae cat2 = new Felidae(false);
            Felidae cat3 = new Felidae(true);

            Console.WriteLine("Cat 1's gender is " + cat1.Male);
            Console.WriteLine("Cat 2's gender is " + cat2.Male);
            Console.WriteLine("Cat 3's gender is " + cat3.Male);

            Lion cat4 = new Lion(true, 200);
            Lion cat5 = new Lion(false, 180);

            Console.WriteLine("Cat 4 is a Lion and it's gender is " + cat4.Male +
                " and weight is " + cat4.Weight);

            Console.WriteLine("Cat 5 is a Lion and it's gender is " + cat5.Male +
                " and weight is " + cat5.Weight);

            Console.ReadKey();
        }
    }
}
