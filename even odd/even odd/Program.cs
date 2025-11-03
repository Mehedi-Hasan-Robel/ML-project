using System;

class EvenNumbers
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Even numbers between 1 and " + n + ":");

        for (int i = 2; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
