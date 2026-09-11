/* Using the built-in System.Text.Json library, the journal now 
 saves and loads in JSON format .json instead of a plain text or csv file.
 The changes are in the Journal class at (SaveToFile and LoadFromFile methods).
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                entry._date = dateText;
                entry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? (example: journal.json) ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Your Journal has been Loaded.");
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? (example: journal.json) ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Your Journal has been Saved.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using this Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice, Try again by typing in a number.");
            }
        }
    }
}