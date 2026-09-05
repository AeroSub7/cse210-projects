using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        float sum = 0;
        int largest = 0;
        float average;
        int smallest = 0;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {

            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                sum = sum + number;

                if (number > largest || largest == 0)
                {
                    largest = number;
                }
                if ((number < smallest && number > 0) || (smallest == 0 && number > 0))
                {
                    smallest = number;
                }
            }
        } while (number != 0);

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        if (largest != 0)
        {
            Console.WriteLine($"The largest number is: {largest}");
        }
        if (smallest != 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallest}");
        }
    }
}