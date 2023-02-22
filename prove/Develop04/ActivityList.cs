public class ActivityList : Activity 
{
  List<string> _prompts = new List<string>();

  private int _noItems = 0;
  private string _answer;

  List<string> _entries = new List<string>();

  private void AddPrompts()
  {
    _prompts.Add("Who are people that you appreciate?");
    _prompts.Add("What are personal strengths of yours?");
    _prompts.Add("Who are people that you have helped this week?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("Who are some of your personal heroes?");
  }

  public void List()
  {
    AddPrompts();
    Random rnd = new Random();
    int index = rnd.Next(_prompts.Count());
    string item = _prompts[index];

    Console.WriteLine("Please enter a duration that you want to do the activity for...");
    int time = Convert.ToInt32(Console.ReadLine());
    int duration = time;

    Console.WriteLine("Think of some items you can list about the following prompt...\n");
    Console.WriteLine(item + ":\n");
    Countdown(3);
                    
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(duration);

    while (DateTime.Now < futureTime)
    {
    _answer = Console.ReadLine();
    _entries.Add(_answer);
    _noItems ++;
    }
    Console.WriteLine("You were able to list " + _noItems + " items within the time you specified!");
    Thread.Sleep(1000);
  }
}