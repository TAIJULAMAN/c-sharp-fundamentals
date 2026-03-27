using System;

class LearnComparisonOperator
{
    static void Main()
    {
        int x = 10;
        int y = 20;
        // Equal to ==
        Console.WriteLine($"x == y: {x == y}"); // False

        // Not equal !=
        Console.WriteLine($"x != y: {x != y}"); // True

        // Greater than >
        Console.WriteLine($"x > y: {x > y}");   // False

        // Less than <
        Console.WriteLine($"x < y: {x < y}");   // True

        // Greater or equal >=
        Console.WriteLine($"x >= y: {x >= y}"); // False

        // Less or equal <=
        Console.WriteLine($"x <= y: {x <= y}"); // True

        // Using comparison in if-else
        if (x < y)
        {
            Console.WriteLine("x is smaller than y");
        }
        else if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }
        else
        {
            Console.WriteLine("x and y are equal");
        }
    }
}