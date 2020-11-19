using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            House myHouse = new House();
            //Room randomRoom = new Room(5.6, 7.8, 3.4);
            Person person1 = new Person("34491M", "Jake", "Grima");
            myHouse.AddRoom(3.5, 4.6, 2.6);
            myHouse.AddPerson(person1);

            Console.WriteLine("The length and width of the first room in " +
                "my house is " + myHouse.Rooms[0].Length + "x" + myHouse.Rooms[0].Width);
            Console.WriteLine("The length and width of the second room in " +
                "my house is " + myHouse.Rooms[1].Length + "x" + myHouse.Rooms[1].Width);
            Console.WriteLine("The first person added to my house is " + 
                myHouse.Persons[0].Name);
            Console.WriteLine("Details of person1 are " + person1.Name + " and " +
                person1.Surname);

            Console.ReadKey();
        }
    }
}
