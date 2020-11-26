using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Zone
    {
        int zoneID;
        double zoneArea;

        List<Animal> animals = new List<Animal>();

        public int ZoneID { get => zoneID; set => zoneID = value; }
        public double ZoneArea { get => zoneArea; set => zoneArea = value; }
        internal List<Animal> Animals { get => animals; set => animals = value; }

        public Zone(int zoneID, double zoneArea)
        {
            this.ZoneID = zoneID;
            this.ZoneArea = zoneArea;
        }
        public void AddAnimal(Animal animal)
        {
            //Aggregation relationship since the instance liftime for the animals
            // is not dependant on the Zone instance
            Animals.Add(animal);
        }
    }
}
