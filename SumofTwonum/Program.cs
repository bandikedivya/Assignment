using System;

public class PS7
{
    public static void Main(string[] args)
    {
        int number1, number2, result;

        Console.Write("Enter first number: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        number2 = int.Parse(Console.ReadLine());

        if (number1 == number2)
        {
            result = 3 * (number1 + number2);
        }
        else
        {
            result = number1 + number2;
        }

        Console.WriteLine("The sum of the two numbers is: {0}", result);
        Console.Read();
    }
}