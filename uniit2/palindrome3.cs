// Write a program to check weather a number is Armstrong or not.
using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit * digit * digit;
            number /= 10;
        }

        if (sum == originalNumber)
        {
            Console.WriteLine("The number is an Armstrong number.");
        }
        else
        {
            Console.WriteLine("The number is not an Armstrong number.");
        }
    }
}