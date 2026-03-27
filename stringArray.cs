using System;

class LearnStringArray
{
    static void Main()
    {

        string[] fruits = { "Apple", "Banana", "Orange" };
        Console.WriteLine("\nString Array:");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }

    }
}