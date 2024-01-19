using System;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main()
    {
        int sum = 0;
        int min = int.MaxValue;
        Console.WriteLine("Insert the number between 0 and 10 and press ENTER. To finish press 5.");
        while (true)
        {
            Console.WriteLine("Number:");
            if (int.TryParse(Console.ReadLine(), out int number))//converting input from the user => number
            {
                if (number >= 0 && number <= 10)
                {
                    sum += number;
                    if (number < min)
                        min = number;
                    if (number == 5)
                        break;//end the loop after pressing 5
                }
                else
                    Console.WriteLine("Value must be a number between 0- 10.");
            }
            else
                Console.WriteLine("Value must be a number between 0- 10.");

        }
        Console.WriteLine($"Sum of the squared results: {Math.Pow(sum, 2)}");
        Console.WriteLine($"The smallest number entered:{min}");
    }
}
