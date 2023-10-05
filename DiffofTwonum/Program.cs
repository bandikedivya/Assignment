using System;

class PS8
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int absoluteDifference = Math.Abs(firstNumber - secondNumber);

        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"The absolute value of the difference is: {absoluteDifference}");
        }
        else
        {
            int doubleAbsoluteDifference = 2 * absoluteDifference;
            Console.WriteLine($"The absolute value of the difference is: {doubleAbsoluteDifference}");
        }
        Console.Read();
    }
}
