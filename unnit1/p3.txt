// write a program to input principal amount rate and year and display simple interest
using System;

class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter Principal Amount: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Rate of Interest (%): ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Time Period (years): ");
        double years = double.Parse(Console.ReadLine());
        
        double simpleInterest = (principal * rate * years) / 100;
        double totalAmount = principal + simpleInterest;
        
        Console.WriteLine($"\nSimple Interest: {simpleInterest}");
        Console.WriteLine($"Total Amount: {totalAmount}");
    }
}