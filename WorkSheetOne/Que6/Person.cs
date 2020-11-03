using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que6
{
    class Person
    {
        int id;
        int age;

        string name;
        string locality;
        string favColour;

        public int ID
        {
            get { return id; } // read option for the property
            set { id = value; } // write option for the property
        }

        public int Age
        {
            get { return age; } // read option for the property
            set { age = value; } // write option for the property
        }

        public string Name
        {
            get { return name; } // read option for the property
            set { name = value; } // write option for the property
        }

        public string Locality
        {
            get { return locality; } // read option for the property
            set { locality = value; } // write option for the property
        }

        public string FavColour
        {
            get { return favColour; } // read option for the property
            set { favColour = value; } // write option for the property
        }

        public int GetID()
        {
            return id;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }

        public string GetLocality()
        {
            return locality;
        }

        public string GetFavColour()
        {
            return favColour;
        }

    }
}
