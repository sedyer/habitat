using Habitat.Math;
using Habitat.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Habitat.UnitTests
{
    [TestClass]
    public class CelestialObjectsTests
    {
        #region Test objects

        static internal CelestialObject sun = new CelestialObject
        {
            Mass = 1.988435e30
        };

        static internal CelestialObject earth = new CelestialObject
        {
            Mass = 5.9721986e24,
            Radius = 6.3710088e6,
            CurrentOrbit = new Orbit { SemimajorAxis = 1496e8 },
            PrimaryBody = sun
        };

        #endregion

        #region Test methods

        [TestMethod]
        public void TestEarthSurfaceEscapeVelocity()
        {
            Assert.IsTrue(Physics.getSurfaceEscapeVelocity(earth) < 11190);

            Assert.IsTrue(Physics.getSurfaceEscapeVelocity(earth) > 11180);
        }

        [TestMethod]
        public void TestEarthOrbitalVelocity()
        {
            Assert.IsTrue(Physics.getOrbitalVelocity(earth) < 29900);

            Assert.IsTrue(Physics.getOrbitalVelocity(earth) > 29700);
        }

        #endregion
    }
}
