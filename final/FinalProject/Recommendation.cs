public class Recommendation : AdsMain
{
  private string _status;

  public Recommendation() {}

  public void Recommend() 
  {
    Console.Clear();
    string[] lines = System.IO.File.ReadAllLines("ads.txt");
    
    _ads.Clear();
    int i = 1;
    foreach (string line in lines)
    {
      string[] parts = line.Split(" | ");
      _status = parts[6];
      Console.WriteLine($"{i}. {parts[0]} | {parts[1]} | Recommendation -- {GetRecommendation(_status)}");
      i++;
    }
    i = 0;
  }

  public string GetRecommendation(string status)
  {
    if (status == "Success")
    {
      return "The ad is doing wonderfully, keep running it!";
    }
    else if (status == "Average")
    {
      return "The ad is doing okay but, you need to watch it.";
    }
    else 
    {
      return "The ad needs to be cancelled.";
    }
  }
}