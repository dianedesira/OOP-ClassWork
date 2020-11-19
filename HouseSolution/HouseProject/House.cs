using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject
{
    class House
    {
        int houseNumber;
        string houseName;
        string streetAddress;
        int telephoneLine;
        double plotSize;

        List<Room> rooms = new List<Room>();
        List<Person> persons = new List<Person>();

        //the internal access modifier means that the elements can only be
        // accessed from different classes which are in the same project
        // any classes outside of the project (even if they have a reference
        // to the project) cannot access the elements.
        internal List<Room> Rooms { get => rooms; set => rooms = value; }
        internal List<Person> Persons { get => persons; set => persons = value; }

        public House()
        {
            Room firstRoom = new Room(); // composition
            Rooms.Add(firstRoom);
            //rooms.Add(new Room());
        }

        public void AddPerson(Person person)
        {
            Persons.Add(person); // aggregation
        }

        public void AddRoom(double length, double width, double height)
        {
            Room newRoom = new Room(length, width, height); // composition
            Rooms.Add(newRoom);
            //rooms.Add(new Room(length, width, height));
        }
    }
}
