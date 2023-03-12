public class EternalGoal : Goal
{
  public EternalGoal(){}
  public EternalGoal(string name, string description, int points) 
    {
      _name = name;
      _description = description;
      _points = points;
    }

  public override bool IsCompleted() {
    return false;
  }

  public override string GetInfo() {
    return $"[ ] {GetName()} ({GetDescription()})";
  }

  public override string Convert()
  {
    return $"EternalGoal&{_name}&{_description}&{_points}";
  }

  public override int AddPoints()
  {
      return _points;
  }
}