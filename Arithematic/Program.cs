using System;

public class Arithematic
{
    public static void Main(string[] args)
    {
        int number1, number2;

        Console.Write("Input the first number: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Input the second number: ");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
        Console.WriteLine("{0} x {1} = {2}", number1, number2, number1 * number2);
        Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
        Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 % number2);
        Console.Read();
    }
}