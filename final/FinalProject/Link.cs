public class Link : Ads
{
  private int _linkClicks;
  
  public Link(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, int linksClicked)
  {
    _name = name; 
    _adType = adType;
    _reach = reach;
    _impressions = impressions; 
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _linkClicks = linksClicked;
    _status = Success();
  }
  public Link(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, string status, int linkClicks) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = status;
    _linkClicks = linkClicks;
  }

  public int GetLinks()
  {
    return _linkClicks;
  }

  public override string DisplayInfo() 
  {
    return $"Name: {GetName()} \n" + $"Ad Type: {GetAdType()}\n" + $"Reach: {GetReach()} \n" + $"Impressions: {GetImpressions()} \n" + $"Cost / Result: {GetResultCost()} \n" + $"Starting Date: {GetStartingDate()} \n" + $"Ad Status: {Success()} \n" + $"Link Clicks: {GetLinks()}";
  }

  public override string ConvertToSave() 
  {
    return $"{GetName()} | {GetAdType()} | {GetReach()} | {GetImpressions()} | {GetResultCost()} | {GetStartingDate()} | {Success()} | {GetLinks()}";
  }

  public override string Success()
  {
    if(((GetImpressions() - GetReach()) / GetLinks()) <= 10)
    {
      return "Success";
    }
    else if (10 < ((GetImpressions() - GetReach()) / GetLinks()) && ((GetImpressions() - GetReach()) / GetLinks()) >= 15)
    {
      return "Average";
    }
    else
    {
      return "Bad";
    }
  }
}








