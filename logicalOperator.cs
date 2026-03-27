using System;

class LearnLogicalOperator
{
    static void Main()
    {
        int age = 19;
        bool hasID = true;
        bool isRegistered = false;

        if (age >= 18 && hasID && !isRegistered)
        {
            Console.WriteLine("You can register to vote");
        }
        else
        {
            Console.WriteLine("You cannot register");
        }

        bool isWeekend = false;
        bool isHoliday = true;

        if (isWeekend || isHoliday)
        {
            Console.WriteLine("You can relax");
        }
        else
        {
            Console.WriteLine("Go to work");
        }
    }
}