using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);
        
        while (guessNumber != magicNumber)
        {
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Guess lower.");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Guess higher.");
            }
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
        }
        if (guessNumber == magicNumber)
        {
            Console.WriteLine("You guessed the magic number!");
        }
    }
}