using System;

namespace FigureAreaCalculator {
    public class Circle : Figure {
        private double _radius;

        public Circle(double radius) {
            Radius = radius;
        }

        public override double CalcArea() {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Radius { get => _radius; set => _radius = value >= 0 ? value : 0; }
    }
}
