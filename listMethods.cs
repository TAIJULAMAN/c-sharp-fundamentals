using System;
using System.Collections.Generic;

class LearnListMethods
{
    static void Main()
    {
        // Create list
        List<int> numbers = new List<int> { 10, 20, 30 };

        Console.WriteLine("Initial List:");
        PrintList(numbers);

        // Add
        numbers.Add(40);
        Console.WriteLine("\nAfter Add(40):");
        PrintList(numbers);

        // Remove
        numbers.Remove(20);
        Console.WriteLine("\nAfter Remove(20):");
        PrintList(numbers);

        // Insert
        numbers.Insert(1, 25);
        Console.WriteLine("\nAfter Insert(1, 25):");
        PrintList(numbers);

        // Count
        Console.WriteLine("\nCount: " + numbers.Count);

        // Contains
        Console.WriteLine("Contains 30? " + numbers.Contains(30));

        // Clear
        numbers.Clear();
        Console.WriteLine("\nAfter Clear:");
        Console.WriteLine("Count: " + numbers.Count);
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}