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