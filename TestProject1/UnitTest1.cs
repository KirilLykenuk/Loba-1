using NUnit.Framework;
using CylinderCalculator;

namespace CylinderCalculator.Test
{
    public class Tests
    {
        [Test]
        public void TestCalculateCylinder()
        {
            double r = 3;
            double h = 10;

            double expectedS = 188.4;
            double expectedV = 244.92;

            double[] result = Program.CalculateCylinder(r, h);
            double S = result[0];
            double V = result[1];

            Assert.AreEqual(expectedS, Math.Round(S, 2));
            Assert.AreEqual(expectedV, Math.Round(V, 2));
        }
    }
}
