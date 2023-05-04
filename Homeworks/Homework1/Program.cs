using System;

namespace EvenNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            //Write a program that initializes a variable 'n' with a positive integer and prints the
            //sum of all even numbers from 1 to 'n' using a loop.

            Console.WriteLine("Enter a positive integer:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            int sum = 0;
            for (int i = 2; i <= n; i += 2)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of all even numbers from 1 to {n} is {sum}.");
        }
    }
}
