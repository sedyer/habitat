using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habitat.Objects
{
    public class Spacecraft : Habitat
    {
        double DeltaVinKmPerSecond { get; set; }
        double AccelerationInG { get; set; }
    }
}
