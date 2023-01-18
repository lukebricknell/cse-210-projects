public class Job
{
  public string _company = "Lumaza Marketing";
  public string _jobTitle = "Owner";
  public int _startYear = 2022;
  public int _endYear = 2023;
  
  public void JobDescription()
  {
    Console.WriteLine($"{_jobTitle} at ({_company}) {_startYear} - {_endYear}.");
  }

}