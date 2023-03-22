using System;

class Program
{
    static void Main(string[] args)
    {
        AdsMain adsMain = new AdsMain();
        Recommendation recommendation = new Recommendation();

        string status = "Running";

        while (status != "Quit")
        {
        Console.WriteLine("Choose an item from the menu\n" + 
        "1. Create an Ad\n" + "2. Update an Ad\n" + "3. View Ads\n" + "4. Get Recommendation\n" + "5. Delete Ad\n" + "6. Quit");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            adsMain.CreateAd();
        }
        else if (choice == "2")
        {
            adsMain.UpdateAd();
        }
        else if (choice == "3")
        {
            adsMain.ViewAds();
        }
        else if (choice == "4")
        {
            recommendation.Recommend();
        }
        else if (choice == "5")
        {
            adsMain.DeleteAd();
        }
        else if (choice == "6")
        {
            status = "Quit";
        }
        else 
        {
            Console.WriteLine("Not a valid option, please try again.");
        }
    }
}} 