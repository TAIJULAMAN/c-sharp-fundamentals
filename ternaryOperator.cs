using System;

class LearnTernaryOperator
{
    static void Main()
    {
        int personAge = 16;
        string canVote = personAge >= 18 ? "Can vote" : "Cannot vote";

        Console.WriteLine("Ternary Operator:");
        Console.WriteLine(canVote);
    }
}