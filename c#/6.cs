using System;

namespace FloydsTriangle
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.Write($"{triangle[row][col],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
