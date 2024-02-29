using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.Write($"{triangle[row][col],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
