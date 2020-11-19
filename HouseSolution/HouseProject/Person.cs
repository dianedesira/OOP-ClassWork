using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject
{
    class Person
    {
        string id;
        string name;
        string surname;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public Person(string id)
        {
            this.Id = id;
        }
        /*
            public Person(string id, string name, string surname)
            {
                this.id = id;
                this.name = name;
                this.surname = surname;
            }
        */
        public Person(string id, string name, string surname) : this(id)
        {
            this.Name = name;
            this.Surname = surname;
        }


    }
}
