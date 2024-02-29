using System;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
