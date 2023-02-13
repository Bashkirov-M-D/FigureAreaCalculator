using System;
using System.IO;

namespace FigureAreaCalculator {
    public abstract class Figure {
        public abstract double CalcArea();

        public static void CalcAreaFromConsole() {
            string type = "";
            while (type.ToLower() != "end") {
                Console.WriteLine("Input figure type (triangle/circle) or end to exit");

                type = Console.ReadLine();
                Figure figure = ChooseFigureType(type);

                if (figure != null) {
                    try {
                        Console.WriteLine($"Figure area is {figure.CalcArea()}");

                    } catch (InvalidOperationException e) {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
        private static Figure ChooseFigureType(string type) {
            Figure figure = null;
            switch (type.ToLower()) {
                case "triangle":
                    Console.WriteLine("Input side a");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input side b");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input side c");
                    double sideC = double.Parse(Console.ReadLine());

                    figure = new Triangle(sideA, sideB, sideC);
                    break;

                case "circle":
                    Console.WriteLine("Input radius");
                    double radius = double.Parse(Console.ReadLine());

                    figure = new Circle(radius);
                    break;

                case "end":
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            return figure;
        }
    }
}