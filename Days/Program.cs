using System;

class Days
{
    static void Main()
    {
        Console.Write("Enter the number of days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        int weeks = remainingDays / 7;
        remainingDays = remainingDays % 7;

        Console.WriteLine($"Years: {years}");
        Console.WriteLine($"Weeks: {weeks}");
        Console.WriteLine($"Days: {remainingDays}");
        Console.Read();
    }
}