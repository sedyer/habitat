namespace Habitat.Objects
{
    public class Orbit
    {
        public CelestialObject OrbitedBody { get; set; }
        public double SemimajorAxis { get; set; }
        public double Eccentricity { get; set; }
        public double Inclination { get; set; }
        public double LongitudeOfAscendingNode { get; set; }
        public double ArgumentOfPeriapsis { get; set; }
        public double TrueAnomaly { get; set; }
    }
}
