using System;

public class PS4
{
    public static void Main(string[] args)
    {
        int x, y, z, result1, result2;

        Console.Write("Enter first number - ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Enter second number - ");
        y = int.Parse(Console.ReadLine());

        Console.Write("Enter third number - ");
        z = int.Parse(Console.ReadLine());

        result1 = (x + y) * z;
        result2 = x * y + y * z;

        Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}", x, y, z, result1, result2);
        Console.Read();
    }
}