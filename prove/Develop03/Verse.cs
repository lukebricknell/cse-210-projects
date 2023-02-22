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