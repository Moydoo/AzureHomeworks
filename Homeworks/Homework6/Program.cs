using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the maximum number for the Fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            while (a <= n)
            {
                Console.Write(a + " ");

                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();
        }
    }
}
