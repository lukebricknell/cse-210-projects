public abstract class Goal : GoalMain
{
  protected string _name; 
  protected string _description;
  protected int _points; 
  protected int _bonusPoints;
  protected bool _isComplete = false;
  protected int _timesToComplete;
  protected int _timesCompleted;
  
  public Goal() {

  }

  public Goal(string name, string description, int points) {
    _name = name;
    _description = description; 
    _points = points;
  }

  public string GetName() {
    return _name;
  }

  public string GetDescription() {
    return _description;
  }
  public int GetBonusPoints()
  {
    return _bonusPoints;
  }


  public abstract string GetInfo();
  public abstract bool IsCompleted();
  public abstract string Convert();
  public abstract int AddPoints();

}