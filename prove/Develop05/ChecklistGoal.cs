public class ChecklistGoal : Goal
{
  protected int _completed;
  protected int _toComplete;

  public ChecklistGoal(string name, string description, int points, int bonusPoints,  int toComplete, int completed) {
    _name = name; 
    _description = description;
    _points = points;
    _completed = completed;
    _toComplete = toComplete;
    _bonusPoints = bonusPoints;
  }
  public void IncreaseCompleted()
  {
    _completed += 1;
  }
  public int GetCompleted()
  {
    return _completed;
  }
  public string GetDone()
  {
    return $"{GetCompleted().ToString()}/{_toComplete.ToString()}";
  }
  public override string GetInfo()
  {
    if (_completed != _toComplete)
    {
    return $"[ ] {GetName()}({GetDescription()} -- You have completed {GetDone()}";
    }
    else 
    {
    return $"[X] {GetName()}({GetDescription()} -- You have completed {GetDone()}";
    }
  }

  public override bool IsCompleted()
  {
    if (_toComplete == _completed){
      return true;
    }
    else {
      return false;
    }
  }

  public override string Convert()
  {
    return $"ChecklistGoal&{_name}&{_description}&{_points}&{_bonusPoints}&{GetCompleted()}&{_toComplete}";
  }

  public override int AddPoints()
  {
    IncreaseCompleted();
    if (_toComplete == _completed)
    {
      _completed = _toComplete;
      return GetBonusPoints();
    }
    else if (_toComplete <= _completed)
    {
      _completed = _toComplete;
      return 0;
    }
    else 
    {
      return _points;
    }
  }
}