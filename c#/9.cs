using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine($"Result of addition: {result}");
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
            return $"{real} + {imaginary}i";
        }
    }
}
