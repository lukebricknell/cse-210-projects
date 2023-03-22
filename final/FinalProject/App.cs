public class App : Ads
{
  private int _downloads;
  private int _linkClicks;
  public App(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, int linkClicks, int downloads) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = Success();
    _linkClicks = linkClicks;
    _downloads = downloads;
  }
  public App(string name, string adType, int reach, int impressions, int costPerResult, string startingDate, string status, int linkClicks, int downloads) {
    _name = name;
    _adType = adType;
    _reach = reach;
    _impressions = impressions;
    _costPerResult = costPerResult;
    _startingDate = startingDate;
    _status = status;
    _linkClicks = linkClicks;
    _downloads = downloads;
  }
  public int GetDownloads()
  {
    return _downloads;
  }

  public int GetLinkClicks()
  {
    return _linkClicks;
  }
  public override string DisplayInfo() 
  {
    return $"Name: {GetName()} \n" + $"Ad Type: {GetAdType()}\n" + $"Reach: {GetReach()} \n" + $"Impressions: {GetImpressions()} \n" + $"Cost / Result: {GetResultCost()} \n" + $"Starting Date: {GetStartingDate()} \n" + $"Ad Status: {Success()} \n" + $"Link clicks: {GetLinkClicks()} \n" + $"Downloads: {GetDownloads()} \n";
  }
  public override string ConvertToSave() 
  {
    return $"{GetName()} | {GetAdType()} | {GetReach()} | {GetImpressions()} | {GetResultCost()} | {GetStartingDate()} | {Success()} | {GetLinkClicks()} | {GetDownloads()}";
  }

  public override string Success()
  {
    if(GetResultCost() <= 10)
    {
      return "Success";
    }
    else if (GetResultCost() > 10 && GetResultCost() > 20)
    {
      return "Average";
    }
    else
    {
      return "Bad";
    }
  }

}