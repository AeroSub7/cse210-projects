/*Exceeding Requirements:
I have Exceeded Requirements by making sure that the word hidden is always a new word and that the number of words hidden is proportional to the length of the scripture.
I have also added getting a random scripture from a text file which is currently masteriesOldTestamentSimplified.txt which is a list of The Old Testament Scripture Masteries.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Added Scripture mastery for old testament
        string filename = "masteriesOldTestamentSimplified.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Scripture> scriptureMasteries = new List<Scripture>();
        List<Reference> masteryReferences = new List<Reference>();
        for (int i = 0; i < lines.Length; i++)
        {
            if ((i % 2) == 0)
            {
                Reference masteryReference = new Reference(i, filename);
                masteryReferences.Add(masteryReference);
            }
            else
            {
                Scripture masteryScripture = new Scripture(masteryReferences[i / 2], lines[i]);
                scriptureMasteries.Add(masteryScripture);
            }
        }

        Console.Clear();
        Console.Write("Choose 'random', 'oaks' or 'eric':");
        string choice = Console.ReadLine();
        // There are three choices for the Scripture, Random Old Testament Scripture Mastery
        if (choice == "random")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, scriptureMasteries.Count);
            Scripture randomScripture = scriptureMasteries[number];
            Memorizer(randomScripture);
        }
        else if (choice == "oaks")
        {
            // "Two of my favorite verses of scripture are in the Twenty-fourth Psalm:"
            // The Desires of Our Hearts (Dallin H. Oaks(1985))
            Reference reference = new Reference("Psalm", 24, 3, 4);
            Scripture oaksFavorite = new Scripture(reference, "Who shall ascend into the hill of the Lord? or who shall stand in his holy place?; He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.");
            Memorizer(oaksFavorite);
        }
        else
        {
            // Default is My favorite scripture
            Scripture ericFavorite = new Scripture();
            Memorizer(ericFavorite);
        }
    }
    static void Memorizer(Scripture scripture)
    {
        Console.Clear();
        string input = "";
        int hideNumber = scripture.GetHideNumber();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        while (input != "quit")
        {
            input = Console.ReadLine();
            if (input == "")
            {
                if (!scripture.IsCompletelyHidden())
                {
                    scripture.HideRandomWords(hideNumber);
                }
                else
                {
                    input = "quit";
                }
            }
        }
    }
}