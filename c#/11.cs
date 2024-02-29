using System;

namespace AbstractShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Triangle
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(3, 4, 5);

            // Calculate and display area and perimeter
            Console.WriteLine($"Circle area: {circle.CalculateArea():0.00}, Circle perimeter: {circle.CalculatePerimeter():0.00}");
            Console.WriteLine($"Triangle area: {triangle.CalculateArea():0.00}, Triangle perimeter: {triangle.CalculatePerimeter():0.00}");
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double CalculateArea()
        {
            // Using Heron's formula to calculate area
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
