using System.IO;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {

        string choice = "0"; 

        Entry entry1 = new Entry();
        Prompt prompt1 = new Prompt();

        while (choice != "3") 
        {
            Console.WriteLine("You have 5 choices, choose one to start:");
            Console.WriteLine("1. Write a new Journal Entry.");
            Console.WriteLine("2. View your Previous Entries.");
            Console.WriteLine("3. Exit.");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                prompt1.ChoosePrompt();
                entry1.Save();
            }
            if (choice == "2")
            {
                entry1.Display();
            }
            if (choice == "3") 
            {
                Console.WriteLine("See ya tomorrow! :)");
            }
        } 
        
    }
}

public class Entry
{
    public string _entry = "This is my first entry in the database!";

    public List<string> _entries = new List<string>();

    public string _date = DateTime.UtcNow.ToString("MM-dd-yyyy");

    public string _fileName = "";

    public string _whatPrompt = Prompt.random;

    public void Save() 
    {

        _entry = Console.ReadLine();

        Console.WriteLine("Type a filename for your new journal entry. Please not you cannot use the / character in your file name");
        _fileName = Console.ReadLine();

       

        using (FileStream fs = File.Create($"{_fileName}"))
        {

        }

        _entries.Add(_fileName);

        using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(_entry);
                outputFile.WriteLine();
                outputFile.WriteLine(_whatPrompt);
                outputFile.Write($"Date written: {_date}");
            }
    }
    public void Display() 
    {
        Console.WriteLine("Choose a filename from one the list below. Type the name of the file.");
        int fileNo = 1;

        foreach (string entry in _entries)
        {
            Console.WriteLine($"{fileNo}. {entry}");
            fileNo ++; 
        }
        string fileChoice = Console.ReadLine();

        string lines = File.ReadAllText(fileChoice);

        Console.WriteLine(lines);
    }
}

public class Prompt
{
    public List<string> _prompts = new List<string>();
    public static string random = "";

    public void CreatePrompt()
    {
        _prompts.Add("What was the craziest part of your day?");
        _prompts.Add("Who is someone you missed today?");
        _prompts.Add("What have you learned from today?");
        _prompts.Add("What is something you wish you would have done today?");
    }

    public void ChoosePrompt()
    {
        CreatePrompt();
        Random rnd = new Random();
        int number = rnd.Next(_prompts.Count);
        random = _prompts[number];

        Console.WriteLine(random);

    }
}