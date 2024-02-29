using System;

namespace ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
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
