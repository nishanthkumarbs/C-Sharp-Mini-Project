using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the Simple Calculator!");
            
            // Prompt user for operator and operands
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
                    // Check if the divisor is 0
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = operand1 / operand2;
                    break;
                case "%":
                    // Check if the divisor is 0
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
            Console.WriteLine("Result: {0} {1} {2} = {3}", operand1, operation, operand2, result);

        }
    }
}
