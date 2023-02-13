using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureAreaCalculator.Tests {
    [TestClass]
    public class CircleTests {

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, Math.PI)]
        [DataRow(2, 4 * Math.PI)]
        public void CalcArea_MultipleRadiuses_ReturnsCirleAreas(double radius, double expected) {
            Circle circle = new Circle(radius);

            double actual = circle.CalcArea();

            Assert.AreEqual(expected, actual);
        }
    }
}