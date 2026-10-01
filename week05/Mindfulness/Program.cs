//  1. Updated ReflectingActivity and ListingActivity so that random prompts and questions are tracked in an unused list, Making sure no random prompts/questions are selected until they have all been used at least once in that session

//  2. Added counters in Program.cs to keep track and log of completed sessions per activity and cumulative time spent practicing mindfulness.

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static int _breathingCount = 0;
    private static int _reflectingCount = 0;
    private static int _listingCount = 0;
    private static int _totalMindfulnessSeconds = 0;
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Session Log Stats:");
            Console.WriteLine($" - Breathing Sessions Completed: {_breathingCount}");
            Console.WriteLine($" - Reflecting Sessions Completed: {_reflectingCount}");
            Console.WriteLine($" - Listing Sessions Completed:    {_listingCount}");
            Console.WriteLine($" - Total Mindfulness Time:       {_totalMindfulnessSeconds} seconds");
            Console.WriteLine("----------------------------------");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                _breathingCount++;
                _totalMindfulnessSeconds += breathing.GetDuration();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                _reflectingCount++;
                _totalMindfulnessSeconds += reflecting.GetDuration();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                _listingCount++;
                _totalMindfulnessSeconds += listing.GetDuration();
            }
            else if (choice == "4")
            {
                keepRunning = false;
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid option. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }

}