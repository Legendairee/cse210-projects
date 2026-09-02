using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string studentScore = Console.ReadLine();
        int scoreRecord = int.Parse(studentScore);

        string letter = "";

        if (scoreRecord >= 90)
        {
            letter = "A";
        }
        else if (scoreRecord >= 80)
        {
            letter = "B";
        }
        else if (scoreRecord >= 70)
        {
            letter = "C";
        }
        else if (scoreRecord >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string plusMinus = "";
        int lastNumber = scoreRecord % 10;

        if (lastNumber >= 7)
        {
            plusMinus = "+";
        }
        else if (lastNumber <= 3)
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }


        if (letter == "A" && plusMinus == "+")
        {
            plusMinus = "";
        }


        if (letter == "F")
        {
            plusMinus = "";
        }

        Console.WriteLine($"Your grade is {letter}{plusMinus}");


        if (scoreRecord >= 70)
        {
            Console.WriteLine("Congratulations!!! You passed your exam.");
        }
        else
        {
            Console.WriteLine("Sorry! You failed the exam. Study harder next time.");
        }
    }
}