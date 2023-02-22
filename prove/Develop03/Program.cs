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
            // prompt1.RemoveWords();
            prompt1.PromptOption();
        }

    }
}

// D&C 58:2–4
// For verily I say unto you, blessed is he that keepeth my commandments, whether in life or in death; and he that is faithful in tribulation, the reward of the same is greater in the kingdom of heaven.