using System;

namespace ResizableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle(5, 10);

            // Display the initial dimensions
            Console.WriteLine("Initial dimensions:");
            Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}");

            // Resize the rectangle
            rectangle.ResizeWidth(15);
            rectangle.ResizeHeight(20);


            // Display the resized dimensions
            Console.WriteLine("\nResized dimensions:");
            Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}");
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
    }
}
