using System;
using System.Numerics;

namespace FigureAreaCalculator {
    public class Triangle : Figure {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC) {
            SetSides(sideA, sideB, sideC);
        }
        public Triangle(Vector3 sides) {
            SetSides(sides.X, sides.Y, sides.Z);
        }

        public override double CalcArea() {
            if (!IsValid())
                throw new InvalidOperationException($"Triangle with sides {A}, {B} and {C} cannot exist");

            double semiPerim = (A + B + C) / 2;
            return Math.Sqrt(semiPerim * (semiPerim - A) * (semiPerim - B) * (semiPerim - C));
        }

        public bool IsRight() {
            if (!IsValid())
                throw new InvalidOperationException($"Triangle with sides {A}, {B} and {C} cannot exist");

            if (A > B && A > C)
                return Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
            if (B > A && B > C)
                return Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2);
            if (C > A && C > B)
                return Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
            return false;
        }

        public void SetSides(double sideA, double sideB, double sideC) {
            A = sideA;
            B = sideB;
            C = sideC;
        }

        public double A { get => _sideA; set => _sideA = value > 0 ? value : 1; }
        public double B { get => _sideB; set => _sideB = value > 0 ? value : 1; }
        public double C { get => _sideC; set => _sideC = value > 0 ? value : 1; }

        private bool IsValid() {
            if (A + B > C && A + C > B && B + C > A)
                return true;
            return false;
        }
    }
}
