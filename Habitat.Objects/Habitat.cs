using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habitat.Objects
{
    public class Habitat
    {
        public string Name { get; set; }

        public double HabitableVolumeInCubicMeters { get; set; }

        public double HabitableVolumePerInhabitant
        {
            get { return CurrentInhabitants.Count != 0 ? HabitableVolumeInCubicMeters / CurrentInhabitants.Count : HabitableVolumeInCubicMeters; }
        }

        List<Person> CurrentInhabitants { get; set; }

        List<HabitatModule> HabitatModules { get; set; }
    }
}
