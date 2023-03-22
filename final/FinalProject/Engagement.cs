public class Engagement : Ads 
{
  private string _engagement; 
  public Engagement(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, string engagement) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = Success();
    _engagement = engagement;
  }
  public Engagement(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, string status, string engagement) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = status;
    _engagement = engagement;
  }
  public string GetEngagement()
  {
    return _engagement;
  }
  public override string DisplayInfo() 
  {
    return $"Name: {GetName()} \n" + $"Ad Type: {GetAdType()}\n" + $"Reach: {GetReach()} \n" + $"Impressions: {GetImpressions()} \n" + $"Cost / Result: {GetResultCost()} \n" + $"Starting Date: {GetStartingDate()} \n" + $"Ad Status: {Success()} \n" + $"Engagement Ranking: {GetEngagement()}";
  }
  public override string ConvertToSave() 
  {
    return $"{GetName()} | {GetAdType()} | {GetReach()} | {GetImpressions()} | {GetResultCost()} | {GetStartingDate()} | {Success()} | {GetEngagement()}";
  }
  public override string Success()
  {
    if(_engagement.ToLower() == "above average")
    {
      return "Success";
    }
    else if (_engagement.ToLower() == "above average")
    {
      return "Average";
    }
    else
    {
      return "Bad";
    }
  }



}