using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("Welcome to Guess My Number Game!!");
            while (guess != magicNumber)
            {
                Console.Write("What is your guess My friend?");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
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
                    Console.WriteLine("You Guessed it!");
                }
            }
            Console.WriteLine($"You made {guessCount} guesses.");

            Console.Write("Do you wanna Play again (Yes or No)?");
            playAgain = Console.ReadLine().ToLower();
            Console.WriteLine();
        }
    }
}