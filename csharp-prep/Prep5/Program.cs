using System;

class Program
{
    static void Main(string[] args)
    {

       displayWelcome();
       string name = promptUserName();
       int number = promptUserNumber();
       int square = squareNumber(number);
       displayResult(name, square);
    }

     static void displayWelcome() 
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string promptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name; 
        }
        static int promptUserNumber() 
        {
            Console.Write("What is your favourite number? (As a whole number)");
            string output = Console.ReadLine();
            int number = int.Parse(output);

            return number; 
        }
        static int squareNumber(int number) 
        {
            return number * number; 
        }
        static void displayResult(string name, int number) 
        {
            Console.WriteLine($"Your name is {name} and your number squared is {number}.");
        }

    
}

/* 
For this assignment, write a C# program that has several simple functions:

DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.
Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
 */