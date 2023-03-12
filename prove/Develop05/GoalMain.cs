public class GoalMain 
{
  private int NAME = 0;
  private int DESCRIPTION = 1;
  private int POINTS = 2;
  private int COMPLETE = 3;
  private int BONUSPOINTS = 3;
  private int TODO = 4;
  private int DONE = 5;
  protected List<Goal> _goal = new List<Goal>();
  private int _totalPoints; 

  public GoalMain()
  {

  }

  // Splitting text
  public string SplitText(string text, int number) {
    char[] delimiterChars = { ',', '.', ':', '\t' };
    string[] words = text.Split(delimiterChars);
    return $"{words[number]}";
  }

  public void AddGoal() {
        Console.WriteLine("The types of Goals are:\n" +
                          "  1. Simple Goal\n" +
                          "  2. Eternal Goal\n" +
                          "  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Write a short description of your goal. ");
        string description = Console.ReadLine();
        Console.Write("How many points would you like to receive for completing this goal? ");
        int points = int.Parse(Console.ReadLine());
       
        if (choice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
            _goal.Add(simpleGoal);
        }

        else if (choice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goal.Add(eternalGoal);
        }

        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be done for it to be completed? ");
            int toComplete = int.Parse(Console.ReadLine());
            Console.Write("Once you've completed the goal, how many points will you receive as a bonus? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonusPoints, toComplete, 0);
            _goal.Add(checklistGoal);
        }
    }

  public void ListGoal() 
  {
    int i = 1;
    foreach (Goal goal in _goal) 
      {
      Console.WriteLine($"{i}. {goal.GetInfo()}");
      i ++;
      } 
    i = 1;
  } 

  public void SaveGoal()
  {
    Console.Write("What is the filename you will save your goals in?");
    string fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        outputFile.WriteLine(_totalPoints);
        
        foreach (Goal goal in _goal)
        {
            outputFile.WriteLine(goal.Convert());
        }
    }
  }

  public void LoadGoals()
  {
      Console.Write("What is the filename for the goal file? ");
      string fileName = Console.ReadLine();
      string[] lines = System.IO.File.ReadAllLines(fileName);
      
      _goal.Clear();
      _totalPoints = int.Parse(lines[0]);
      foreach (string line in lines.Skip(1))
      {
          string[] parts = line.Split("&");
          if (parts[0] == "SimpleGoal")
          {
          SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]),bool.Parse(parts[4]) );
          _goal.Add(simpleGoal);
          }
          else if (parts[0] == "EternalGoal")
          {
          EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
          _goal.Add(eternalGoal);
          }
          if (parts[0] == "ChecklistGoal")
          {
          ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
          _goal.Add(checklistGoal);
          }
      }
  }

  public void RecordEvent()
    {
        Console.WriteLine("\nYour goals are:");
        int lineNumber = 1;
        foreach (Goal goal in _goal)
        {
            Console.WriteLine($"{lineNumber}. {goal.GetName()}");
            lineNumber++;
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        int pointsReceived = _goal[goalNumber].AddPoints();
        
        Console.WriteLine(_goal[goalNumber].GetBonusPoints());
        if (pointsReceived == 0)
        {
            Console.WriteLine($"This goal is already completed. You have received {pointsReceived} points.");
        }
        else if (pointsReceived == _goal[goalNumber].GetBonusPoints())
        {
            Console.WriteLine($"Congratulations you've completed your goal! You have received {pointsReceived} points.");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have received {pointsReceived} points!");
        }

        _totalPoints += pointsReceived;
        Console.WriteLine($"You now have {_totalPoints} points.");
    }
}