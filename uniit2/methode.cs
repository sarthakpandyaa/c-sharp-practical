using System;

public class Rectangle
{
    private double length;
    private double width;

    // Default constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    // Parameterized constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Method to calculate area
    public double Area()
    {
        return length * width;
    }

    // Method to display values
    public void Display()
    {
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Area: {Area()}");
    }
}