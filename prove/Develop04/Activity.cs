public class Activity
{
  private string _statementBegin;
  private string _statementEnd = "Congratulations you've finished the activity!! Choose another activity from the menu or press quit to end the programme :)";
  private string _description;
  private int _duration;
  public int _activities = 0;

  public Activity()
  {

  }

  public Activity(string statementBegin, string description)
  {
    _statementBegin = statementBegin; 
    _description = description; 
  }

  public void DisplayMessages()
  {
    Console.WriteLine(_statementBegin);
    Console.WriteLine(_description);
  }

  public void DisplayEndMessage()
  {
    Console.WriteLine(_statementEnd);
    Spinner();
  }

  public void Spinner()
  {
    Console.Write("||");

    Thread.Sleep(500);

    Console.Write("\b\b"); // Erase the + character
    Console.Write(">>"); // Replace it with the - character
    
    Thread.Sleep(500);

    Console.Write("\b\b");
    Console.Write("||");

    Thread.Sleep(500);

    Console.Write("\b\b");
    Console.Write("<<");

    Thread.Sleep(500);

    Console.Write("\b\b");
    Console.Write("||");

    Thread.Sleep(500);

    Console.Write("\b\b");
    Console.Write(">>");

    Thread.Sleep(500);

    Console.Write("\b\b");
    Console.Write("||");

    Thread.Sleep(500);

    Console.Write("\b\b");
    Console.Write("<<");

    Thread.Sleep(500);

    Console.Write("\b\b");

  }
  
  public void Countdown(int num)
  {
    for (int i = num; i >= 0; i--)
    {
    Console.Write(i.ToString()); 
    Thread.Sleep(1000);
    Console.Write("\b");
    }
  }

  public void Clear()
  {
    Console.Clear();
  }

  public int GetTime()
  {
    Console.WriteLine("Please write in seconds the amount of time you would like to spend on the activity...");
    _duration = Console.Read();
    int timeAmt = Convert.ToInt32(_duration);
    return timeAmt;
  }

}