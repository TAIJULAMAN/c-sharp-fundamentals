using System;

class LearnLoop
{
    static void Main()
    {
        Console.WriteLine("For Loop:");
        for (int i = 1; i <= 3; i++)
            Console.WriteLine(i);

        Console.WriteLine("\nWhile Loop:");
        int j = 1;
        while (j <= 3)
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine("\nDo-While Loop:");
        int k = 1;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k <= 3);

        Console.WriteLine("\nForeach Loop:");
        string[] fruits = { "Apple", "Banana", "Orange" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}