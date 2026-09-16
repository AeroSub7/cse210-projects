using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference("1 Corinthians", 15, 22);

        Scripture favorite = new Scripture(reference, "For as in Adam all die, even so in Christ shall all be made alive.");
        string input = "";
        int hideNumber = favorite.GetHideNumber();
        Console.WriteLine(favorite.GetDisplayText());
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        while (input != "quit")
        {
            input = Console.ReadLine();
            if (input == "")
            {
                if (!favorite.IsCompletelyHidden())
                {
                    favorite.HideRandomWords(hideNumber);
                }
                else
                {
                    input = "quit";
                }
            }
        }
    }
}