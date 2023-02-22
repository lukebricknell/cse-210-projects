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
        if (_list.Count() == 0)
        {
          _isQuit = false;
          Console.Clear();
          Console.WriteLine("Thank you for participating!");
        }
        else 
        {
        Random random = new Random();
        int number = random.Next(_list.Count() - 1);
        // Console.WriteLine(_list.Count());
        _list.RemoveAt(number);
        }
    }
}