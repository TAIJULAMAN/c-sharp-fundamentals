using System;

class LearnStringMethods
{
    static void Main()
    {
        string name = "Aman";
        string greeting = "Hello";

        // Combine strings
        string message = greeting + " " + name;
        Console.WriteLine(message);

        // Interpolation
        int age = 20;
        Console.WriteLine($"Name: {name}, Age: {age}");

        // String methods
        string text = "  Hello World  ";
        Console.WriteLine(text.Trim());
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.Contains("World"));
        Console.WriteLine(text.Replace("World", "C#"));
        string[] words = text.Trim().Split(' ');
        Console.WriteLine(words[0]);
        Console.WriteLine(words[1]);

        // Verbatim string
        string path = @"C:\Users\Aman\Documents";
        Console.WriteLine(path);
    }
}