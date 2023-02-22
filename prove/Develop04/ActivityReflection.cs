using System;
using System.Collections.Generic;

public class ActivityReflection : Activity 
{
  private List<string> _Questions = new List<string>();
  private List<string> _ReflectQs = new List<string>();

  private void AddQuestions()
  {
    _Questions.Add("Think of a time when you stood up for someone else.");
    _Questions.Add("Think of a time when you did something really difficult.");
    _Questions.Add("Think of a time when you helped someone in need.");
    _Questions.Add("Think of a time when you did something truly selfless.");
  }

  public void AddReflections()
  {
     _ReflectQs.Add("Why was this experience meaningful to you?");
    _ReflectQs.Add("Have you ever done anything like this before?");
    _ReflectQs.Add("How did you get started?");
    _ReflectQs.Add("What did you learn about yourself through this experience?");
    _ReflectQs.Add("What made this time different than other times when you were not as successful?");
    _ReflectQs.Add("What is your favorite thing about this experience?");
  }

  public void Reflect()
  {
    AddQuestions();
    AddReflections();

    Console.WriteLine("Please enter a duration that you want to do the activity for...");
    int time = Convert.ToInt32(Console.ReadLine());
    int duration = time;

    Console.WriteLine("Starting Activity in...");
    Countdown(4);
                    
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(duration);

    while (DateTime.Now < futureTime)
    {
    if(_Questions.Count() == 0)
    {
      AddQuestions();
    }
    Random rnd = new Random();
    int randIndex = rnd.Next(_Questions.Count());
    string random = _Questions[randIndex];

    Console.WriteLine(random);
    _Questions.Remove(random);

    _ReflectQs.Clear();
    AddReflections();
    Thread.Sleep(500);
    Console.WriteLine();
    Console.WriteLine("Ponder the following questions related to the experience you thought of...");
    Thread.Sleep(500);

    for(int ii = 0; ii < (_ReflectQs.Count()-2); ii ++)
    {
      Random number = new Random();
      int randIndex1 = number.Next(_ReflectQs.Count());
      string item = _ReflectQs[randIndex1];

      Console.WriteLine(" - " + item);
      _ReflectQs.Remove(item);

      Thread.Sleep(5000);
    } 
    Console.WriteLine("");
    }
  }
}