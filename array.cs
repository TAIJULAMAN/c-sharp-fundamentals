using System;

class LearnArray
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // String Array
        string[] fruits = { "Apple", "Banana", "Orange" };
        Console.WriteLine("\nString Array:");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }

    }
}