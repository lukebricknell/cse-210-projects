using System;

class Program
{
    static void Main(string[] args)
    {
       bool running = true;
       GoalMain goalMain = new GoalMain();

       while(running == true) 
       {
        Console.WriteLine("Please choose an item from the menu: \n" + "1. Create Goal \n" + "2. List Goals \n" + "3. Save Goals \n" + "4. Load Goals \n" + "5. Record Event \n" + "6. Quit");
       string choice = Console.ReadLine();
       if (choice == "1")
       {
        goalMain.AddGoal();
       }
       else if (choice == "2")
       {
        goalMain.ListGoal();
       }
       else if (choice == "3")
       {
        goalMain.SaveGoal();
       }
       else if (choice == "4")
       {
        goalMain.LoadGoals();
       }
       else if (choice == "5")
       {
        goalMain.RecordEvent();
       }
       else if (choice == "6")
       {
        running = false;
       }
       else
       {
        Console.WriteLine("That is not a valid choice, please choose again.");
       }
       
       }

    }
}
