using System;

class Program
{
    static void Main(string[] args)
    {
        //2
        // Create a program that asks the user for two integers and uses a conditional statement to display
        //the greater number.


        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"The greater number is {num1}");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"The greater number is {num2}");
        }
        else
        {
            Console.WriteLine("The numbers are equal.");
        }

        Console.ReadKey();
    }
}
