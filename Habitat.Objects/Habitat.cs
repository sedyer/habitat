using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Habitat.Objects;

namespace Habitat.Objects
{
    public class Habitat
    {
        #region Attributes

        public string Name { get; set; }

        public double HabitableVolume { get; set; }

        public double HabitableVolumePerInhabitant { get; set; }

        public Orbit CurrentOrbit { get; set; }

        List<Person> CurrentInhabitants { get; set; }

        List<Habitat> AttachedHabitats { get; set; }

        List<Module> HabitatModules { get; set; }

        #endregion

        #region Methods

        public double getHabitableVolume(Habitat hab)
        {
            double totalVolume = 0;

            foreach (Habitat h in AttachedHabitats)
            {
                totalVolume += h.HabitableVolume;
            }

            return totalVolume;
        }

        public double getHabitableVolumePerInhabitant(Habitat hab)
        {
            double totalVolume = 0;

            foreach (Habitat h in AttachedHabitats)
            {
                totalVolume += h.HabitableVolume;
            }

            return CurrentInhabitants.Count > 0 ? totalVolume / CurrentInhabitants.Count : totalVolume;
        }

        #endregion
    }

    
}
