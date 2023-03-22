public class Sales : Ads 
{
  private int _sales; 

  public Sales(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, int sales) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = Success();
    _sales = sales;
  }

  public Sales(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, string status, int sales) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = status;
    _sales = sales;
  }

  
  public override string DisplayInfo() 
  {
    return $"Name: {GetName()} \n" + $"Ad Type: {GetAdType()}\n" + $"Reach: {GetReach()} \n" + $"Impressions: {GetImpressions()} \n" + $"Cost / Result: {GetResultCost()} \n" + $"Starting Date: {GetStartingDate()} \n" + $"Ad Status: {Success()} \n" + $"Sales: {GetResultCost()}";
  }
  public override string ConvertToSave() 
  {
    return $"{GetName()} | {GetAdType()} | {GetReach()} | {GetImpressions()} | {GetResultCost()} | {GetStartingDate()} | {Success()} | {GetResultCost()}";
  }

  public override string Success()
  {
    if(GetResultCost() >= 400)
    {
      return "Success";
    }
    else if (GetResultCost() > 400 && GetResultCost() >= 600 )
    {
      return "Average";
    }
    else
    {
      return "Bad";
    }
  }

}