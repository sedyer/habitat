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

        internal double G = 6.67e-11;

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
                return PrimaryBody != null ? System.Math.Sqrt((G * (Mass + PrimaryBody.Mass)) / SemimajorAxis) : 0;
            }
        }

        public double SurfaceEscapeVelocity
        {
            get
            {
                return Radius == 0 ? 0 : System.Math.Sqrt((2 * (G * Mass)) / Radius);
            }
        }
    }
}
