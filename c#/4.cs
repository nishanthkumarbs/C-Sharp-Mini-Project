using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Division by Zero Exception
            try
            {
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator;
                Console.WriteLine($"Division result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Division by zero error: {ex.Message}");
            }

            // Index Out of Range Exception
            try
            {
                int[] array = new int[5];
                int index = 10;
                int element = array[index];
                Console.WriteLine($"Element at index {index}: {element}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index out of range error: {ex.Message}");
            }
        }
    }
}
