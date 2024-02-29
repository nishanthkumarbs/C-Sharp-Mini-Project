using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator and Armstrong Number Checker!");
            Console.WriteLine("Enter 1 for Simple Calculator or 2 for Armstrong Number Checker:");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    RunCalculator();
                    break;
                case "2":
                    RunArmstrongChecker();
                    break;
                case "3":
                        pro3();
                        break;
                  case "4":
                        pro4();
                        break;
                case "5":
                        pro5();
                        break;
                case "6":
                    pro6();
                    break;
                case "7":
                    pro7();
                    break;
                case "8":
                    pro8();
                    break;
                case "9":
                    pro9();
                    break;
                case "10":
                    pro10();
                    break;
                case "11":
                    pro11();
                    break;
                case "12":
                    pro12();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter either 1 or 2.");
                    break;
            }
        }
     static void pro12()
        {
            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle(5, 10);

            // Display the initial dimensions
            Console.WriteLine("Initial dimensions:");
            Console.WriteLine("Width:"+ rectangle.Width+","+" Height:"+ rectangle.Height);

            // Resize the rectangle
            rectangle.ResizeWidth(15);
            rectangle.ResizeHeight(20);


            // Display the resized dimensions
            Console.WriteLine("\nResized dimensions:");
            Console.WriteLine("Width:"+rectangle.Width+"," +"Height:" +rectangle.Height);
        }
    }

    public interface IResizable
    {
        void ResizeWidth(int width);
        void ResizeHeight(int height);
    }

    public class Rectangle : IResizable
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void ResizeWidth(int width)
        {
            Width = width;
        }

        public void ResizeHeight(int height)
        {
            Height = height;
        }
         static void pro11(string[] args)
        {
            // Create instances of Circle and Triangle
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(3, 4, 5);

            // Calculate and display area and perimeter
            Console.WriteLine("Circle area:"+ circle.CalculateArea():0.00+","+ "Circle perimeter:" {circle.CalculatePerimeter():0.00});
            Console.WriteLine("Triangle area:" +{triangle.CalculateArea():0.00}+","+ "Triangle perimeter:" +triangle.CalculatePerimeter():0.00);
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

         static void pro10()
        {
            shape[] shapes = new shape[3];

            // Create instances of the derived classes
            shapes[0] = new circle();
            shapes[1] = new triangle();
            shapes[2] = new square();

            while (true)
            {
                Console.WriteLine("Enter the shape you want to draw and erase (circle, triangle, square) or type 'exit' to quit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                shape selectedShape = null;

                switch (input.ToLower())
                {
                    case "circle":
                        selectedShape = shapes[0];
                        break;
                    case "triangle":
                        selectedShape = shapes[1];
                        break;
                    case "square":
                        selectedShape = shapes[2];
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                }

                selectedShape.draw();
                selectedShape.erase();
            }
        }
    }

    class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing a shape");
        }

        public virtual void erase()
        {
            Console.WriteLine("Erasing a shape");
        }
    }

    class circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a circle");
        }

        public override void erase()
        {
            Console.WriteLine("Erasing a circle");
        }
    }

    class triangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a triangle");
        }

        public override void erase()
        {
            Console.WriteLine("Erasing a triangle");
        }
    }

    class square : shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a square");
        }

        public override void erase()
        {
            Console.WriteLine("Erasing a square");
        }
         static void pro9()
        {
            // Read the first complex number from the user
            Console.Write("Enter the real part of the first complex number: ");
            double realPart1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the imaginary part of the first complex number: ");
            double imaginaryPart1 = Convert.ToDouble(Console.ReadLine());

            Complex complex1 = new Complex(realPart1, imaginaryPart1);

            // Read the second complex number from the user
            Console.Write("Enter the real part of the second complex number: ");
            double realPart2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the imaginary part of the second complex number: ");
            double imaginaryPart2 = Convert.ToDouble(Console.ReadLine());

            Complex complex2 = new Complex(realPart2, imaginaryPart2);

            // Perform the addition and display the result
            Complex result = complex1 + complex2;
            Console.WriteLine("Result of addition: "+result);
        }
    }

    public class Complex
    {
        private double real;
        private double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            double real = c1.real + c2.real;
            double imaginary = c1.imaginary + c2.imaginary;
            return new Complex(real, imaginary);
        }

        public override string ToString()
        {
            return {real} "+" {imaginary}"i";
        }
        static void pro8()
        {
            Stack stack = new Stack();

            while (true)
            {
                Console.WriteLine("Enter 'push' to add an element to the stack, 'pop' to remove an element, or 'exit' to quit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (input.ToLower() == "push")
                {
                    Console.Write("Enter the value to push onto the stack: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    stack.Push(value);
                    Console.WriteLine("Pushed"+ value+ "onto the stack.");
                }
                else if (input.ToLower() == "pop")
                {
                    try
                    {
                        int value = stack.Pop();
                        Console.WriteLine("Popped" +value+" from the stack.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }

    public class Stack
    {
        private List<int> data;

        public Stack()
        {
            data = new List<int>();
        }

        public int Count
        {
            get { return data.Count; }
        }

        public void Push(int item)
        {
            data.Add(item);
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int lastIndex = data.Count - 1;
            int item = data[lastIndex];
            data.RemoveAt(lastIndex);
            return item;
        }
         static void pro7()
        {
            try
            {
                Console.Write("Enter the source file path: ");
                string sourceFilePath = Console.ReadLine();

                Console.Write("Enter the destination file path: ");
                string destinationFilePath = Console.ReadLine();

                // Read the source file contents
                string fileContents = File.ReadAllText(sourceFilePath);

                // Write the contents to the destination file
                File.WriteAllText(destinationFilePath, fileContents);

                Console.WriteLine("File copied successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred:" +{ex.Message});
            }
        }
         static void pro6()
        {
            Console.Write("Enter the number of rows in Floyd's Triangle: ");
            int numRows = Convert.ToInt32(Console.ReadLine());

            int[][] triangle = GenerateFloydsTriangle(numRows);

            Console.WriteLine("\nFloyd's Triangle:");
            PrintFloydsTriangle(triangle);
        }

        static int[][] GenerateFloydsTriangle(int numRows)
        {
            int[][] triangle = new int[numRows][];

            int num = 1;

            for (int row = 0; row < numRows; row++)
            {
                triangle[row] = new int[row + 1];

                for (int col = 0; col <= row; col++)
                {
                    triangle[row][col] = num++;
                }
            }

            return triangle;
        }

        static void PrintFloydsTriangle(int[][] triangle)
        {
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write({triangle[row][col],3});
                }
                Console.WriteLine();
            }
        }
        static void pro5()
        {
            Console.Write("Enter the number of rows in Pascal's Triangle: ");
            int numRows = Convert.ToInt32(Console.ReadLine());

            int[][] triangle = GeneratePascalTriangle(numRows);

            Console.WriteLine("\nPascal's Triangle:");
            PrintPascalTriangle(triangle);
        }

        static int[][] GeneratePascalTriangle(int numRows)
        {
            int[][] triangle = new int[numRows][];

            for (int row = 0; row < numRows; row++)
            {
                triangle[row] = new int[row + 1];
                triangle[row][0] = 1;
                triangle[row][row] = 1;

                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }
            }

            return triangle;
        }

        static void PrintPascalTriangle(int[][] triangle)
        {
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write({triangle[row][col],3});
                }
                Console.WriteLine();
            }
        }

        static void pro4(string[] args)
        {
            // Division by Zero Exception
            try
            {
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator;
                Console.WriteLine("Division result:" +{result});
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero error: {ex.Message}");
            }

            // Index Out of Range Exception
            try
            {
                int[] array = new int[5];
                int index = 10;
                int element = array[index];
                Console.WriteLine("Element at index"+ {index}":" {element});
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range error: {ex.Message}");
            }
        }
         static void pro3()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            List<string> substrings = GetAllSubstrings(input);

            Console.WriteLine("All substrings:");
            foreach (string substring in substrings)
            {
                Console.WriteLine(substring);
            }
        }

        static List<string> GetAllSubstrings(string input)
        {
            List<string> substrings = new List<string>();

            for (int start = 0; start < input.Length; start++)
            {
                for (int length = 1; length <= input.Length - start; length++)
                {
                    string substring = input.Substring(start, length);
                    substrings.Add(substring);
                }
            }

            return substrings;
        }

        static void RunCalculator()
        {
            Console.WriteLine("Simple Calculator:");

            Console.Write("Enter the operator (+, -, *, /, %): ");
            string operation = Console.ReadLine();

            Console.Write("Enter the first operand: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second operand: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            // Perform the calculation based on the operator
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = operand1 / operand2;
                    break;
                case "%":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = operand1 % operand2;
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            // Display the result
            Console.WriteLine("Result:"+ {operand1}+ {operation} +{operand2} "=" {result});
        }

        static void RunArmstrongChecker()
        {
            Console.WriteLine("Armstrong Numbers between 1 to 1000:");
            for (int number = 1; number <= 1000; number++)
            {
                if (IsArmstrong(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsArmstrong(int number)
        {
            int sum = 0;
            int originalNumber = number;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit * digit;
                number /= 10;
            }

            return sum == originalNumber;
        }
    }
}
