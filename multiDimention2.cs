using System;

class Learn3DArray
{
    static void Main()
    {
        int[,,] cube = {
            { {1, 2}, {3, 4} },
            { {5, 6}, {7, 8} }
        };

        Console.WriteLine("Access element:");
        Console.WriteLine(cube[1, 0, 1]); // 6

        Console.WriteLine("\nAll elements:");

        for (int i = 0; i < cube.GetLength(0); i++)
        {
            Console.WriteLine($"Layer {i}:");

            for (int j = 0; j < cube.GetLength(1); j++)
            {
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    Console.Write(cube[i, j, k] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}