public class Leads : Ads 
{
  private int _leads;

  public Leads(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, int leads)
  {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = Success();
    _leads = leads;
  }
  public Leads(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, string status, int leads)
  {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = status;
    _leads = leads;
  }
  public int GetLeads() 
  {
    return _leads;
  }
  public int GetLeadCost()
  {
    return _costPerResult;
  }
  public override string DisplayInfo() 
  {
    return $"Name: {GetName()} \n" + $"Ad Type: {GetAdType()}\n" + $"Reach: {GetReach()} \n" + $"Impressions: {GetImpressions()} \n" + $"Cost / Result: {GetResultCost()} \n" + $"Starting Date: {GetStartingDate()} \n" + $"Ad Status: {Success()} \n" + $"Leads: {GetLeads()}";
  }
  public override string ConvertToSave() 
  {
    return $"{GetName()} | {GetAdType()} | {GetReach()} | {GetImpressions()} | {GetResultCost()} | {GetStartingDate()} | {Success()} | {GetLeads()}";
  }
  public override string Success()
  {
    if(GetLeadCost() <= 15)
    {
      return "Success";
    }
    else if (GetLeadCost() < 15 && GetLeadCost() <= 20 )
    {
      return "Average";
    }
    else
    {
      return "Bad";
    }
  }
}