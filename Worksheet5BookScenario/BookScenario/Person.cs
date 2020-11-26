using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookScenario
{
    class Person
    {
        string name;
        string surname;
        int id;
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Id { get => id; set => id = value; }

        public Person(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }
}
