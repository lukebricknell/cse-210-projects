public class AdsMain
{
  protected string _name;
  protected string _adType;
  protected int _reach;
  protected int _impressions;
  protected int _costPerResult;
  protected string _startingDate;
  protected List<Ads> _ads = new List<Ads>();

  public AdsMain(){}

  public void CreateAd() 
  {
    Console.Clear();
    LoadAds();
    Console.WriteLine("The types of Ad Types are:\n" +
                      "  1. Awareness\n" +
                      "  2. Link Clicks\n" +
                      "  3. Leads\n" +
                      "  4. Sales\n" +
                      "  5. Engagement\n" + 
                      "  6. App Downloads");
    Console.Write("Which type of ad would you like to create? ");
    int adChoice = int.Parse(Console.ReadLine());

    Console.Write("What is the name of your ad? ");
    string name = Console.ReadLine();
    Console.Write("How many people has your ad reached?");
    int reach = int.Parse(Console.ReadLine());
    Console.Write("How many impressions does your ad have?");
    int impressions = int.Parse(Console.ReadLine());
    Console.Write("What is the cost per result of your ad so far?");
    int costPerResult = int.Parse(Console.ReadLine());
    Console.Write("When did your ad start running?");
    string startingDate = Console.ReadLine();
    
    if (adChoice == 1)
    {
      Awareness awareness = new Awareness(name, "Awareness", reach, impressions, costPerResult, startingDate);
      _ads.Add(awareness);
    }

    else if (adChoice == 2)
    {
      Console.Write("How many link clicks does your ad have so far?");
      int linkClicks = int.Parse(Console.ReadLine());

      Link link = new Link(name, "Link Clicks", reach, impressions, costPerResult, startingDate, linkClicks);
      _ads.Add(link);
    }

    else if (adChoice == 3)
    {
      Console.Write("How many leads does your ad have so far? ");
      int totalLeads = int.Parse(Console.ReadLine());

      Leads leads = new Leads(name, "Leads", reach, impressions, costPerResult, startingDate, totalLeads);
      _ads.Add(leads);
    }

    else if (adChoice == 4)
    {
      Console.Write("How many sales has your ad generated so far? ");
      int totalSales = int.Parse(Console.ReadLine());

      Sales sales = new Sales(name, "Sales", reach, impressions, costPerResult, startingDate, totalSales);
      _ads.Add(sales);
    }
    
    else if (adChoice == 5)
    {
      Console.Write("What is the engagement ranking on your ad? (Choose between Above Average, Average or Bad.)");
      string engagements = Console.ReadLine();

      Engagement engagement = new Engagement(name, "Engagement", reach, impressions, costPerResult, startingDate, engagements);
      _ads.Add(engagement);
    }
    
    else if (adChoice == 6)
    {
      Console.Write("How many link clicks does your ad have? ");
      int linkClicks = int.Parse(Console.ReadLine());
      Console.Write("How many Downloads does your ad have?? ");
      int downloads = int.Parse(Console.ReadLine());

      App app = new App(name, "App Downloads", reach, impressions, costPerResult, startingDate, linkClicks, downloads);
      _ads.Add(app);
    }

    SaveAd();
    Console.Clear();
    }

  public void ViewAds() 
  {
    Console.Clear();
    LoadAds();
    if (_ads.Count() > 0)
    {
      int i = 1;
      foreach (Ads ad in _ads) 
        {
        Console.WriteLine($"Ad no.{i}\n" + ad.DisplayInfo());
        Console.WriteLine("\n-------------------------------------------- \n");
        i ++;
        } 
      i = 1;
    }
    else
    {
      Console.WriteLine("You have not added any ads yet.");
    }
  }

  public void UpdateAd() 
  {
    Console.Clear();
    LoadAds();
    if (_ads.Count() > 0)
    {
    int i = 1;
    Console.WriteLine();  
    foreach (Ads ad in _ads) 
      {
      Console.WriteLine($"{i}. {ad.GetName()} | {ad.GetAdType()} | {ad.GetReach()} | {ad.GetStatus()}");
      i ++;
      } 
    i = 1;

    Console.WriteLine($"\nWrite the number of the ad you'd like to update.");
    int choice = int.Parse(Console.ReadLine()) - 1;

    if (choice <= _ads.Count())
    {
      Console.WriteLine($"--Your Ad's last recorded metrics--\n{_ads[choice].DisplayInfo()}");
      Update(choice);
    }
    else 
    {
      Console.WriteLine("Invalid option, please try again.");
    }

    }
    else 
    {
      Console.WriteLine("You have not added any ads yet.");
    }


  }

  public void DeleteAd()
  {
    Console.Clear();
    LoadAds();
    if (_ads.Count() > 0)
    {
    int i = 1;
    foreach (Ads ad in _ads) 
      {
      Console.WriteLine($"{i}. {ad.GetName()} | {ad.GetAdType()} | {ad.GetReach()} | {ad.GetStatus()}");
      i ++;
      } 
    i = 1;

    Console.WriteLine("Write the number of the ad you would like to delete.");
    int choice = int.Parse(Console.ReadLine());

    if (choice <= _ads.Count())
    {
    _ads.RemoveAt(choice - 1);

    SaveAd();
    }
    else
    {
      Console.WriteLine("Invalid option, pleaset try again.");
    }

    }
    else 
    {
      Console.WriteLine("You have not added any ads yet.");
    }
    Console.Clear();
  }

  public void SaveAd()
  {
    using (StreamWriter outputFile = new StreamWriter("ads.txt"))
    {
      foreach (Ads ad in _ads)
      {
          outputFile.WriteLine(ad.ConvertToSave());
      }
    }
  }

  public void LoadAds() 
  {
    string[] lines = System.IO.File.ReadAllLines("ads.txt");
    
    _ads.Clear();
    foreach (string line in lines)
    {
      string[] parts = line.Split(" | ");
      if (parts[1] == "Awareness")
      {
      Awareness awareness = new Awareness(parts[0], "Awareness", int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), parts[5]);
      _ads.Add(awareness);
      }
      else if (parts[1] == "Link Clicks")
      {
      Link link = new Link(parts[0], "Link Clicks", int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6], int.Parse(parts[7])); 
      _ads.Add(link);
      }
      else if (parts[1] == "Leads")
      {
      Leads leads = new Leads(parts[0], "Leads", int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6], int.Parse(parts[7]));
      _ads.Add(leads);
      }
      else if (parts[1] == "Sales")
      {
      Sales sales = new Sales(parts[0], "Sales", int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6], int.Parse(parts[7]));
      _ads.Add(sales);
      }
      else if (parts[1] == "Engagement")
      {
      Engagement engagement = new Engagement(parts[0], "Engagement", int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6], parts[7]);
      _ads.Add(engagement);
      }
      else if (parts[1] == "App Downloads")
      {
      App app = new App(parts[0], "Sales", int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6], int.Parse(parts[7]), int.Parse(parts[8]));
      _ads.Add(app);
      }
    }
  }

  public void Update(int choice)
  {
    LoadAds();

    string name = _ads[choice].GetName();
    Console.Write("How many people has your ad reached now?");
    int reach = int.Parse(Console.ReadLine());
    Console.Write("How many impressions does your ad have now?");
    int impressions = int.Parse(Console.ReadLine());
    Console.Write("What is the cost per result of your ad so far now?");
    int costPerResult = int.Parse(Console.ReadLine());
    string startingDate = _ads[choice].GetStartingDate();
    string status = _ads[choice].GetStatus();

    if (_ads[choice].GetAdType() == "Awareness")
    {
      Awareness awareness = new Awareness(name, _ads[choice].GetAdType(), reach, impressions, costPerResult, startingDate, status);
      _ads[choice] = awareness;
    }

    else if (_ads[choice].GetAdType() == "Link Clicks")
    {
      Console.Write("How many link clicks does your ad have now?");
      int linkClicks = int.Parse(Console.ReadLine());

      Link link = new Link(name, _ads[choice].GetAdType(), reach, impressions, costPerResult, startingDate, status, linkClicks); 
      _ads[choice] = link;
    }

    else if (_ads[choice].GetAdType() == "Leads")
    {
      Console.Write("How many leads does your ad have now?");
      int generatedLeads = int.Parse(Console.ReadLine());

      Leads leads = new Leads(name, _ads[choice].GetAdType(), reach, impressions, costPerResult, startingDate, status, generatedLeads);
      _ads[choice] = leads;
    }

    else if (_ads[choice].GetAdType() == "Sales")
    {
      Console.Write("How many sales does your ad have now?");
      int generatedSales = int.Parse(Console.ReadLine());

      Sales sales = new Sales(name, _ads[choice].GetAdType(), reach, impressions, costPerResult, startingDate, status, generatedSales);
      _ads[choice] = sales;
    }

    else if (_ads[choice].GetAdType() == "Engagement")
    {
      Console.Write("What is the engagement ranking on your ad now?");
      string engagementRanking = Console.ReadLine();
      
      Engagement engagement = new Engagement(name, _ads[choice].GetAdType(), reach, impressions, costPerResult, startingDate, status, engagementRanking);
      _ads[choice] = engagement;
    }

    else if (_ads[choice].GetAdType() == "App Downlaods")
    {
      Console.Write("How many downloads does your ad have now?");
      int downloads = int.Parse(Console.ReadLine());
      Console.Write("How many link clicks does your ad have now?");
      int linkClicks = int.Parse(Console.ReadLine());

      App app = new App(name, _ads[choice].GetAdType(), reach, impressions, costPerResult, startingDate, status, linkClicks, downloads);
      _ads[choice] = app;
  }
  SaveAd();
}
}

