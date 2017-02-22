using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habitat.Objects
{
    public class SolarSystem
    {
        public List<CelestialObject> CelestialObjects { get; set; } = new List<CelestialObject>();
        public List<Habitat> Habitats { get; set; } = new List<Habitat>();
        public List<Person> Persons { get; set; } = new List<Person>(); 
    }
}
