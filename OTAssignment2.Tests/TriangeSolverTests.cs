using System;
using NUnit.Framework;

namespace OTAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]
        public void DigitsFormScaleneTriangle()
        {
            StringAssert.Contains("Scalene" , TriangleSolver.Analyze(12, 6, 14));
        }
        [Test]
        public void DigitsFormEquilateralTriangle()
        {
            StringAssert.Contains("Equilateral", TriangleSolver.Analyze(4, 4, 4));
        }
        [Test]
        public void DigitsFormIsoscelesTriangle()
        {
            StringAssert.Contains("Isosceles", TriangleSolver.Analyze(6, 6, 4));
        }
        [Test]
        public void DigitsDoNotFormTriangle()
        {
            StringAssert.Contains("do not form", TriangleSolver.Analyze(12, 6, 4));
        }
        [Test]
        public void DigitsDoFormTriangle()
        {
            StringAssert.Contains("do form", TriangleSolver.Analyze(6, 6, 6));
        }
        [Test]
        public void DigitsDoNotFormScaleneTriangle()
        {
            StringAssert.DoesNotContain("Scalene" , TriangleSolver.Analyze(4, 4, 4));
        }
        [Test]
        public void DigitsDoNotFormEquilateralTriangle()
        {
            StringAssert.DoesNotContain("Equilateral", TriangleSolver.Analyze(12, 6, 14));
        }
        [Test]
        public void DigitsDoNotFormIsoscelesTriangle()
        {
            StringAssert.DoesNotContain("Isosceles", TriangleSolver.Analyze(4, 4, 4));
        }
    }
}
