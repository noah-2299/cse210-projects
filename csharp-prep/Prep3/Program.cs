using System;

class Program
{
    static void Main(string[] args)
    {
        //
        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
        //Create a new Random Magic number for the user to guess
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        // Set the variable of guess to an integer out side of the range so that the data type is set but it cannot match before the user has guessed
        int guess = 0;
        // do while runs the first time and gets a guess, loop keeps running until the user guesses right.
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed It!");
            }
        } while (guess!= magicNumber);
        Console.WriteLine("Would you like to play again? ");
        keepPlaying = Console.ReadLine();
        }
    }
}