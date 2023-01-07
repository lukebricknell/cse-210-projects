using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string output = Console.ReadLine();

        int guess = int.Parse(output); 

        int plays = 0; 

        while(guess != magicNumber) 
        {
            if (guess < magicNumber) 
            {
                Console.WriteLine("Higher");

                Console.Write("What is your guess? ");
                output = Console.ReadLine();

                guess = int.Parse(output); 
                plays ++;
            }
            else 
            {
                Console.WriteLine("Lower");

                Console.Write("What is your guess? ");
                output = Console.ReadLine();

                guess = int.Parse(output); 
                plays ++;
            }
        }

        if (guess == magicNumber)
        {
            plays ++;
            Console.WriteLine("Well done you guessed the right number!");
            Console.WriteLine($"It only took you {plays} guesses to guess the right number!");
        }
            
        Console.Write("Would you like to play again? ");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            Console.Write("What is your guess? ");
            output = Console.ReadLine();

            guess = int.Parse(output);
        }
        else 
        {
            Console.WriteLine("Thanks for playing, see you next time!");
        }

    }
}