using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Habitat.Objects;

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
            SemimajorAxis = 1496e8,
            PrimaryBody = sun
        };

        #endregion

        #region Test methods

        [TestMethod]
        public void TestEarthSurfaceEscapeVelocity()
        {
            Assert.IsTrue(earth.SurfaceEscapeVelocity < 11190);

            Assert.IsTrue(earth.SurfaceEscapeVelocity > 11180);
        }

        [TestMethod]
        public void TestEarthOrbitalVelocity()
        {
            Assert.IsTrue(earth.OrbitalVelocity < 29900);

            Assert.IsTrue(earth.OrbitalVelocity > 29700);
        }

        #endregion
    }
}
