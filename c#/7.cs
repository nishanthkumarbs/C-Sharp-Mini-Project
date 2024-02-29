using System;
using System.IO;

namespace FileCopy
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
