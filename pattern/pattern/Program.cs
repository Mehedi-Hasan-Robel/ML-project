using System;

class Program
{
    static void Main()
    {
        int rows = 3;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = i; j < i + 4; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

