using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        int count;
        int magicNumber;
        string play;
        Random randomGenerator;
        do
        {
            count = 0;
            randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101);
            //Console.Write("What is the magic number? ");
            //magicNumber = int.Parse(Console.ReadLine());
            do
            {
                count = count + 1;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You Guessed it! {count} guesses to get it.");
                }
            } while (guess != magicNumber);
            Console.Write("Do you want to play again(yes/no)? ");
            play = Console.ReadLine();
        } while (play == "yes");
        Console.WriteLine("Have a great day!!!!");

    }
}