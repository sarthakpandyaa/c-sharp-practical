using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrime numbers between " + a + " and " + b + ":");

        for (int i = a; i <= b; i++)
        {
            if (i < 2)
                continue;

            bool isPrime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}
