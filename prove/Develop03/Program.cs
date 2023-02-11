using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        scripture1.ReferencePrompt();
        scripture1.ScripturePrompt();

        Verse verse1 =  new Verse(scripture1.GetScripture());

        Prompt prompt1 = new Prompt(verse1._verse, scripture1.GetReference());

        prompt1._isQuit = true;
        verse1.ConvertToList();

        while (prompt1._isQuit)
        {
            prompt1.RemoveWords();
            prompt1.PromptOption();
        }

    }
}

public class Scripture
{
    private string _scripture;
    private string _reference; 


    public string ReferencePrompt()
    {
        Console.WriteLine("Please enter the reference to your favourite Scripture");
        _reference = Console.ReadLine();
        return _reference;
    }
    public string ScripturePrompt()
    {
        Console.WriteLine("Please enter the content of the Scripture");
        _scripture = Console.ReadLine();
        return _scripture;
    }

    public string GetScripture()
    {
        return _scripture;
    }

    public string GetReference()
    {
        return _reference;
    }
}

public class Verse
{
    public List<string> _verse = new List<string>();
    private string _splitScripture;

    public Verse(string scripture)
    {
        _splitScripture = scripture;
    }

    public void ConvertToList()
    {
        
        string[] splittedStringArray = _splitScripture.Split(' ');

        foreach (string stringInArray in splittedStringArray) {
        _verse.Add(stringInArray);
}
    }
}

public class Prompt
{
    private string _isEnter; 
    public bool _isQuit;
    private string _reference;

    List<string> _list;

    public Prompt(List<string> list, string reference)
    {
        _list = list;
        _reference = reference;
    }

    public void PromptOption()
    {
        Console.WriteLine("Pick one of the folling:");
        Console.WriteLine("1. Click enter to remove some of the words in the scripture.");
        Console.WriteLine("2. Type Quit to end the programme.");
        _isEnter = Console.ReadLine();

        if (_isEnter == "")
        {
            RemoveWords();
        }
        else 
        {
            _isQuit = false;
        }
        Console.Clear();
    }

    public void RemoveWords()
    {
        Console.WriteLine(_reference);
        for(int i = 0; i < _list.Count(); i++)
        {
            if (_list[i] != ".")
            {
                Console.Write(_list[i] + " ");
            }
            else {
                Console.WriteLine(_list[i]);
            }
        }
        Random random = new Random();
        int number = random.Next(_list.Count());
        _list.RemoveAt(number);
    }
}

// D&C 58:2–4
// For verily I say unto you, blessed is he that keepeth my commandments, whether in life or in death; and he that is faithful in tribulation, the reward of the same is greater in the kingdom of heaven.