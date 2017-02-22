using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Habitat.Objects
{
   public class CelestialObject
    {
        //constants

        internal double G = 6.674e-10;

        //object characteristics

        public string Name { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }

        //orbital characteristics

        public CelestialObject PrimaryBody { get; set; }

        public double SemimajorAxis { get; set; } = 0;

        public double OrbitalVelocity
        {
            get
            {
                return SemimajorAxis != 0 ? System.Math.Sqrt((G * Mass) / SemimajorAxis) : 0;
            }
        }

        public double SurfaceEscapeVelocity
        {
            get
            {
                return System.Math.Sqrt((G * Mass) / Radius) * System.Math.Sqrt(2);
            }
        }
    }
}
