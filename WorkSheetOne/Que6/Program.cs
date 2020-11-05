using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(23399);
            Person p2 = new Person(457790, "Mark", 30, "Marsaxlokk", "Purple");

            //p1.ID = 23399;
            p1.Age = 21;
            p1.FavColour = "Yellow";
            p1.Name = "Amy";
            p1.Locality = "Naxxar";

            /*p2.ID = 457790;
            p2.Age = 30;
            p2.FavColour = "Purple";
            p2.Name = "Mark";
            p2.Locality = "Marsaxlokk";
            */

            Person[] persons = new Person[2];
            persons[0] = p1;
            persons[1] = p2;

            /* foreach (type )item in collection
             * do { statements }
             */

            int[] marks = {55, 89, 90, 100, 67 };

            Console.WriteLine("List of all marks:\n");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            Console.WriteLine("\nList and details of all persons:\n");
            foreach (Person p in persons)
            {
                Console.WriteLine("\nID: " + p.GetID());
                Console.WriteLine("Name: " + p.GetName());
                Console.WriteLine("Age: " + p.GetAge());
                Console.WriteLine("Locality: " + p.GetLocality());
                Console.WriteLine("Favourite Colour: " + p.GetFavColour());
            }

            Console.ReadKey();
        }
    }
}
