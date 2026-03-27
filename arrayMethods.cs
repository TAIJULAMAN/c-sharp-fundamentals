using System;

class LearnArrayMethods
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 2 };

        // Original Array
        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(" ", arr));

        // Sort
        Array.Sort(arr);
        Console.WriteLine("\nSorted:");
        Console.WriteLine(string.Join(" ", arr));

        // Reverse
        Array.Reverse(arr);
        Console.WriteLine("\nReversed:");
        Console.WriteLine(string.Join(" ", arr));

        // IndexOf
        int index = Array.IndexOf(arr, 2);
        Console.WriteLine("\nFirst index of 2: " + index);

        // LastIndexOf
        int lastIndex = Array.LastIndexOf(arr, 2);
        Console.WriteLine("Last index of 2: " + lastIndex);

        // Exists
        bool exists = Array.Exists(arr, x => x > 5);
        Console.WriteLine("\nAny number > 5: " + exists);

        // Find
        int found = Array.Find(arr, x => x > 5);
        Console.WriteLine("First number > 5: " + found);

        // FindAll
        int[] foundAll = Array.FindAll(arr, x => x > 2);
        Console.WriteLine("All numbers > 2: " + string.Join(" ", foundAll));

        // TrueForAll
        bool allPositive = Array.TrueForAll(arr, x => x > 0);
        Console.WriteLine("\nAll numbers > 0: " + allPositive);

        // BinarySearch (array must be sorted)
        Array.Sort(arr);
        int searchIndex = Array.BinarySearch(arr, 5);
        Console.WriteLine("\nBinary search index of 5: " + searchIndex);

        // Copy
        int[] copy = new int[arr.Length];
        Array.Copy(arr, copy, arr.Length);
        Console.WriteLine("\nCopied Array:");
        Console.WriteLine(string.Join(" ", copy));

        // Clone
        int[] clone = (int[])arr.Clone();
        Console.WriteLine("\nCloned Array:");
        Console.WriteLine(string.Join(" ", clone));

        // Resize
        Array.Resize(ref arr, 7);
        Console.WriteLine("\nResized Array:");
        Console.WriteLine(string.Join(" ", arr));

        // Clear
        Array.Clear(arr, 0, 2);
        Console.WriteLine("\nAfter Clear (first 2 elements):");
        Console.WriteLine(string.Join(" ", arr));

        // Length
        Console.WriteLine("\nLength of array: " + arr.Length);
    }
}