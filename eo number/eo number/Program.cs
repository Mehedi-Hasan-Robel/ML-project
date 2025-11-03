using System;

class Program
{
    static void Main()
    {
        int sumOdd = 0, sumEven = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += i;
            }
            else
            {
                sumOdd += i;
            }
        }

        Console.WriteLine("Sum of even numbers: " + sumEven);
        Console.WriteLine("Sum of odd numbers: " + sumOdd);
    }
}

