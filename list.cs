using System;
using System.Collections.Generic;

class LearnList
{
    static void Main()
    {
        // Declare a list of integers
        List<int> numbers = new List<int>();

        // Add elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Print elements
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}