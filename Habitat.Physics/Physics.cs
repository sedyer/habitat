using Habitat.Objects;

namespace Habitat.Math
{
    public static class Physics
    {
        #region Constants

        internal static double G = 6.67e-11;

        #endregion

        #region Test methods

        public static double getOrbitalVelocity(CelestialObject body)
        {
            return body.PrimaryBody != null && body.CurrentOrbit.SemimajorAxis > 0 ? System.Math.Sqrt((G * (body.Mass + body.PrimaryBody.Mass)) / body.CurrentOrbit.SemimajorAxis) : 0;
        }

        public static double getSurfaceEscapeVelocity(CelestialObject body)
        {
            return body.Radius == 0 ? 0 : System.Math.Sqrt((2 * (G * body.Mass)) / body.Radius);
        }

        #endregion
    }
}
