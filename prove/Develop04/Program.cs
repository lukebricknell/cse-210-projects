using System;

class Program
{
    static void Main(string[] args)
    {
        Activity new1 = new Activity();
        ActivityBreathing new2 = new ActivityBreathing();
        ActivityReflection new3 = new ActivityReflection();
        ActivityList new4 = new ActivityList();

        Thread.Sleep(3000);


        bool _isQuit = true;

        while (_isQuit)
        {
            Console.WriteLine("Welcome! Please choose an activity to do");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();


            if (choice == "1")
            {
                Activity mess1 = new Activity("Welcome to the Breathing Activity!", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                mess1.DisplayMessages();
            
                new2.Breathe();
                new2.DisplayEndMessage();
                new1.Clear();
            }
            else if(choice == "2")
            {
                Activity mess2 = new Activity("Welcome to the Reflection Activity!", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                mess2.DisplayMessages();

                new3.Reflect();

                new3.DisplayEndMessage();
                new1.Clear();
            }
            else if(choice == "3")
            {
                Activity mess3 = new Activity("Welcome to the Listing Activity!", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                mess3.DisplayMessages();
                
                
                new4.List();
                new3.DisplayEndMessage();
                new1.Clear();
            }
            else if (choice.ToLower() == "quit" || choice == "4")
            {
                _isQuit = false;
                new1.Clear();
            }
            else 
            {
                Console.WriteLine("That isn't a choice please try again.");
                new1.Clear();
            }
        }
    }
}