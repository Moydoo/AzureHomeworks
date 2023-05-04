using System;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ListSize = 10;
            double[] numbers = new double[ListSize];

            // Prompt the user to enter each number
            for (int i = 0; i < ListSize; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    i--; // Decrement index to retry input
                }
            }

            // Calculate the average
            double sum = 0;
            for (int i = 0; i < ListSize; i++)
            {
                sum += numbers[i];
            }
            double average = sum / ListSize;

            Console.WriteLine($"The average of the numbers is: {average}");
            Console.ReadKey();
        }
    }
}
