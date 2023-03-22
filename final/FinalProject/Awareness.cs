public class Awareness : Ads 
{
  public Awareness(string name, string adType, int reach, int impressions, int costPerResult, string startingDate) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = Success();
  }
  public Awareness(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, string status) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = status;
  }
  public override string DisplayInfo() 
  {
    return $"Name: {GetName()} \n" + $"Ad Type: {GetAdType()}\n" + $"Reach: {GetReach()} \n" + $"Impressions: {GetImpressions()} \n" + $"Cost / Result: {GetResultCost()} \n" + $"Starting Date: {GetStartingDate()} \n" + $"Ad Status: {Success()}";
  }
  public override string ConvertToSave() 
  {
    return $"{GetName()} | {GetAdType()} | {GetReach()} | {GetImpressions()} | {GetResultCost()} | {GetStartingDate()} | {Success()}";
  }
  public override string Success()
  {
    if((GetImpressions() / GetReach()) >= 1.2)
    {
      return "Success";
    }
    else if (1 < (GetImpressions() / GetReach()) && (GetImpressions() / GetReach()) <= 1.2)
    {
      return "Average";
    }
    else
    {
      return "Bad";
    }
  }
}