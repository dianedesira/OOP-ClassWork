using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class ZooKeeper
    {
        int id;
        string name;
        string surname;
        string animalSpecialty;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string AnimalSpecialty { get => animalSpecialty; set => animalSpecialty = value; }

        public ZooKeeper(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
