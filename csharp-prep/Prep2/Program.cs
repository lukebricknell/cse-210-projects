using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string output = Console.ReadLine();
        int percent = int.Parse(output);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}

/* Console.Write("What grade did you get? ");
        string answer = Console.ReadLine();
        
        int grade = int.Parse(answer);

        if (grade >= 90) 
        {
        Console.WriteLine("You got an A");
        }
        else if (grade >= 80) 
        {
        Console.WriteLine("You got an B");
        }
        else if (grade >= 70) 
        {
        Console.WriteLine("You got an C");
        }
        else if (grade >= 60) 
        {
        Console.WriteLine("You got an D");
        }
        else 
        {
        Console.WriteLine("You got an F");
        } */