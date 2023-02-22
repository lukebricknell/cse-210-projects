public class ActivityBreathing : Activity 
{
  private string _inhale = "Breathe in...";
  private string _exhale = "Now breathe out...";

  public void Breathe()
  {
    Console.WriteLine("Please enter a duration that you want to do the activity for...");
    int time = Convert.ToInt32(Console.ReadLine());
    int duration = time;
    
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(duration);

    while (DateTime.Now < futureTime)
    {
    Console.Write(_inhale);
    Countdown(2);
    Console.WriteLine();


    Console.Write(_exhale);
    Countdown(4);
    Console.WriteLine();
    Console.WriteLine();
    }
  }
}

// Console.WriteLine("Please enter a duration that you want to do the activity for...");
//                 int time = Convert.ToInt32(Console.ReadLine());
//                 int duration = time;
                
//                 DateTime startTime = DateTime.Now;
//                 DateTime futureTime = startTime.AddSeconds(duration);

//                 while (DateTime.Now < futureTime)
//                 {
//                 Console.WriteLine(DateTime.Now);
//                 Console.WriteLine(futureTime);
//                 new2.Breathe();
//                 }