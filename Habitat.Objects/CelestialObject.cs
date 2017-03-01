namespace Habitat.Objects
{
    public class CelestialObject
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }
        public Orbit CurrentOrbit { get; set; }
    }
}
