using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;

        Console.WriteLine("Enter marks of 5 students:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
            sum += marks[i];
        }

        double average = (double)sum / marks.Length;

        Console.WriteLine($"\nTotal Marks: {sum}");
        Console.WriteLine($"Average Marks: {average:F2}");
    }
}