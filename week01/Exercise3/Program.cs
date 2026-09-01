using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guessCount = 0;
            int guess;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > number)
                {
                    Console.WriteLine("Guess Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Guess Higher");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("Congratulations! You guessed right.");
                }

            } while (guess != number);

            Console.WriteLine($"It took you {guessCount} guesses");
            Console.Write("Would you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine().ToLower();
            Console.WriteLine("===========================================");
            Console.WriteLine("");
        }

        Console.WriteLine("Thank you for playing. Goodbye");
        Console.WriteLine("====================================");
    }
}