using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;

namespace task4_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PerimeterIsEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 12;
            double actual = triangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimeterIsNotEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 15;
            double actual = triangle.GetPerimeter();
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void PerimeterWithPointsIsEqual()
        {
            PointOfTriangle A = new PointOfTriangle() { X = 0, Y = 0 };
            PointOfTriangle B = new PointOfTriangle() { X = 0, Y = 3 };
            PointOfTriangle C = new PointOfTriangle() { X = 4, Y = 0 };
            Triangle triangle = new Triangle(A, B, C);
            double expected = 12;
            double actual = triangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimeterWithPointsIsNotEqual()
        {
            PointOfTriangle A = new PointOfTriangle() { X = 0, Y = 0 };
            PointOfTriangle B = new PointOfTriangle() { X = 0, Y = 3 };
            PointOfTriangle C = new PointOfTriangle() { X = 4, Y = 0 };
            Triangle triangle = new Triangle(A, B, C);
            double expected = 6;
            double actual = triangle.GetPerimeter();
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void SquareIsEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;
            double actual = triangle.GetSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareIsNotEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 8;
            double actual = triangle.GetSquare();
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void SquareWithPointsIsEqual()
        {
            PointOfTriangle A = new PointOfTriangle() { X = 0, Y = 0 };
            PointOfTriangle B = new PointOfTriangle() { X = 0, Y = 3 };
            PointOfTriangle C = new PointOfTriangle() { X = 4, Y = 0 };
            Triangle triangle = new Triangle(A, B, C);
            double expected = 6;
            double actual = triangle.GetSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareWithPointsIsNotEqual()
        {
            PointOfTriangle A = new PointOfTriangle() { X = 0, Y = 0 };
            PointOfTriangle B = new PointOfTriangle() { X = 0, Y = 3 };
            PointOfTriangle C = new PointOfTriangle() { X = 4, Y = 0 };
            Triangle triangle = new Triangle(A, B, C);
            double expected = 12;
            double actual = triangle.GetSquare();
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectedException()
        {
            Triangle triangle = new Triangle(0, 10, 15);
            double actual = triangle.GetPerimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectedException1()
        {
            Triangle triangle = new Triangle(5, 10, 15);
            double actual = triangle.GetPerimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectedExceptionWithPoints()
        {
            PointOfTriangle A = new PointOfTriangle() { X = 20, Y = 5 };
            PointOfTriangle B = new PointOfTriangle() { X = 0, Y = 100 };
            PointOfTriangle C = new PointOfTriangle() { X = 20, Y = 5 };
            Triangle triangle = new Triangle(A, B, C);
        }

    }
}
