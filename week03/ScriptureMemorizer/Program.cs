/*
I implemented a ScriptureLibrary class that hold a collection of scriptures. 
The program randomly pick one scripture from the library using GetRandomScripture()
method for the user to practice, rather than a single scripture that is store inside
string member variable.
*/

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {

        ScriptureLibrary library = new ScriptureLibrary();

        List<Reference> references = new List<Reference>
        {
            new Reference("Proverbs", 3, 5, 6),
            new Reference("John", 3, 16),
            new Reference("Philippians", 4, 13),
            new Reference("Psalm", 23, 1),
            new Reference("Genesis", 1, 1),
            new Reference("Romans", 8, 28),
            new Reference("Matthew", 11, 28),
            new Reference("Joshua", 1, 9),
            new Reference("Jeremiah", 29, 11),
            new Reference("1 Corinthians", 13, 4, 5)
        };

        Console.WriteLine("Fetching scriptures online, please wait.....\n");

        foreach (Reference reference in references)
        {
            Console.WriteLine($"Fetching {reference.GetDisplayText()}...");
            Scripture scripture = await ScriptureFetcher.FetchScriptureAsync(reference);

            if (scripture != null)
            {
                library.AddScripture(scripture);
            }
        }

        Scripture selectedScripture = library.GetRandomScripture();

        if (selectedScripture == null)
        {
            Console.WriteLine("\nCould not load any scriptures. Please check your internet connection.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            if (selectedScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }
    }

}
