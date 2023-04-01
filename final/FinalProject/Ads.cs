public abstract class Ads : AdsMain
{
  protected string _status;
  public abstract string Success() ;
  public abstract string DisplayInfo();
  public abstract string ConvertToSave();

  public string GetName()
  {
    return _name; 
  }

  public string GetAdType()
  {
    return _adType;
  }
  public int GetReach() {

    return _reach;
  }
  public int GetImpressions() 
  {
    return _impressions;
  }
  public string GetStartingDate()
  {
    return _startingDate;
  }
  public int GetResultCost() 
  {
    return _costPerResult;
  }
  public string GetStatus()
  {
    return _status;
  }

}