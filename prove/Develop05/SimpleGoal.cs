public class SimpleGoal : Goal
{
  public SimpleGoal(string name, string description, int points, bool isComplete)
  {
    _name = name;
    _description = description;
    _points = points;
    _isComplete = isComplete;
  }

  public override string GetInfo()
  {
    if (_isComplete == false)
    {
    return $"[ ] {GetName()}({GetDescription()})";
    }
    else 
    {
      return $"[ ] {GetName()}({GetDescription()})";
    }
  }

  public override bool IsCompleted()
  {
    return true;
  }
  
  public override string Convert()
  {
    return $"SimpleGoal&{_name}&{_description}&{_points}&{_isComplete}";
  }

  public override int AddPoints()
  {
    return _points;
  }
}