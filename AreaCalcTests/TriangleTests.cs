using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaCalculator;
using System;

namespace FigureAreaCalculatorTests {
    [TestClass]
    public class TriangleTests {

        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(13, 14, 15, 84)]
        public void CalcArea_MultipleTriangles_ReturnsAreas(double sideA, double sideB, double sideC, double expected) {
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double actual = triangle.CalcArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcArea_InvalidSidesInput_ThrowsException() {
            Triangle triangle = new Triangle(1, 1, 2);

            Action actual = () => triangle.CalcArea();

            Assert.ThrowsException<InvalidOperationException>(actual);
        }

        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(3, 4, 6, false)]
        public void IsRight_MultipleTriangles_ReturnsCorrectCheckResult(double sideA, double sideB, double sideC, bool expected) {
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool actual = triangle.IsRight();

            Assert.AreEqual(expected, actual);
        }
    }
}
